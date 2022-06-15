using ApiGateway.DataModels;
using MassTransit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts;
using Shared.Contracts.HotelManager;
using Shared.Contracts.OfferManager;
using Shared.Contracts.OrderManager;
using Shared.Contracts.TransportManager;
using Shared.DataModels.Offer;

namespace ApiGateway.Controllers
{
    [ApiController]
    [Route("offer")]
    public class OfferController : ControllerBase
    {
        private readonly IBus _bus;
        private readonly IRequestClient<GetOffers> _clientGetOffersFiltered;        
        
        private readonly IRequestClient<IsOfferAvailable> _clientIsOfferAvailable;
        private readonly IRequestClient<RefreshOffer> _clientRefreshOffer;

        private readonly IRequestClient<BookOrder> _clientBookOrder;
        private readonly IRequestClient<PurchaseOrder> _clientPurchaseOrder;
        private readonly IRequestClient<GetLocations> _clientGetLocations;
        private readonly IRequestClient<GetHotelById> _getStaticData;
        private readonly IRequestClient<GetTransportById> _getStaticDataTransport;
        private readonly ILogger<OfferController> _logger;


        public OfferController(ILogger<OfferController> logger, IRequestClient<BookOrder> clientBookOrder, IRequestClient<PurchaseOrder> clientPurchaseOrder,
            IRequestClient<GetOffers> clientGetOffersFiltered, IRequestClient<GetLocations> clientGetLocations, IRequestClient<IsOfferAvailable> clientIsOfferAvailable,
            IRequestClient<GetHotelById> getStaticData, IRequestClient<GetTransportById> getStaticDataTransport, IBus bus, IRequestClient<RefreshOffer> clientRefreshOffer)
        {
            _clientBookOrder = clientBookOrder;
            _clientPurchaseOrder = clientPurchaseOrder;
            _clientGetOffersFiltered = clientGetOffersFiltered;
            _clientGetLocations = clientGetLocations;
            _clientIsOfferAvailable = clientIsOfferAvailable;
            _getStaticData = getStaticData;
            _getStaticDataTransport = getStaticDataTransport;
            _logger = logger;
            _bus = bus;
            _clientRefreshOffer = clientRefreshOffer;
        }

        [HttpGet("get")]
        public async Task<IEnumerable<OfferStatic>> GetOffers([FromQuery] OfferFilter offerFilter)
        {
            _logger.LogInformation("get request received");
            // Requirements 1 and 2
            // Note that we are assuming that offers HAVE TO be filtered to display anything
            var request = new GetOffers(offerFilter);
            var response = await _clientGetOffersFiltered.GetResponse<GetOffersResult>(request);

            IEnumerable<Offer> offers = response.Message.Offers;

            List<OfferStatic> finalOffers = new List<OfferStatic>();
            foreach (var offer in offers)
            {
                var request_hotel = new GetHotelById { HotelId = offer.Hotel.HotelId };
                var response_hotel = await _getStaticData.GetResponse<GetHotelByIdResult>(request_hotel);
                var request_to = new GetTransportById { TransportId = offer.TransportTo.TransportId };
                var response_to = await _getStaticDataTransport.GetResponse<GetTransportByIdResult>(request_to);
                var request_from = new GetTransportById { TransportId = offer.TransportBack.TransportId };
                var response_from = await _getStaticDataTransport.GetResponse<GetTransportByIdResult>(request_from);
                finalOffers.Add(new OfferStatic
                {
                    offer = offer,
                    hotelData = response_hotel.Message.Hotel,
                    transportTo = response_to.Message.Transport,
                    transportBack = response_from.Message.Transport
                });
            }

            await _bus.Publish(new OffersFetched (response.Message));

            return finalOffers;
        }

        [HttpGet("list-locations")]
        public async Task<IEnumerable<string>> ListLocations()
        {
            _logger.LogInformation("list locations request received");
            var request = new GetLocations();
            var response = await _clientGetLocations.GetResponse<GetLocationsResult>(request);
            var result = response.Message;
            return result.Locations;
        }

        [HttpPost("is-available")]
        public async Task<bool> IsAvailable([FromBody] Offer offer)
        {
            // TODO: Add new price per offer part(transports and hotel)
            _logger.LogInformation("is available request received");
            // Requirements 6, 7, 8 (we want to achieve them differently, but it still might turn out to be helpful)
            var request = new IsOfferAvailable(offer);
            var response = await _clientIsOfferAvailable.GetResponse<IsOfferAvailableResult>(request);
            var result = response.Message;
            return result.IsAvailable;
        }

        [HttpPost("refresh-offer")]
        public async Task<Offer?> RefreshOffer([FromBody] Offer offer)
        {
            _logger.LogInformation("Refresh Offer received");

            var request = new RefreshOffer(offer);
            var response = await _clientRefreshOffer.GetResponse<RefreshOfferResult>(request);
            var result = response.Message;
            return result.Offer;
        }

        [Authorize]
        [HttpPost("book")]
        public async Task<IActionResult> BookOffer([FromBody] Offer offer)
        {
            _logger.LogInformation("book request received");
            // Requirement 5

            // Get userId from cookies
            var userId = User.FindFirst("Id")?.Value;
            if (userId == null)
            {
                // Should never happen, cause we are authorized (see [Authorize] attribute)
                return Unauthorized();
            }

            int userIdInt = int.Parse(userId);

            // Build order from offer
            var request = new BookOrder()
            {
                Guid = Guid.NewGuid(),
                UserId = userIdInt,
                Offer = offer
            };

            // Send request to OrderManager and await response
            var response = await _clientBookOrder.GetResponse<BookOrderResult>(request);

            return Ok(response.Message);
        }

        [Authorize]
        [HttpPost("purchase")]
        public async Task<IActionResult> PurchaseOffer([FromBody] OrderPayment payment)
        {
            // Requirement 6
            // Get userId from cookies
            var userId = User.FindFirst("Id")?.Value;
            if (userId == null)
            {
                // Should never happen, cause we are authorized (see [Authorize] attribute)
                return Unauthorized();
            }

            int userIdInt = int.Parse(userId);

            // Build order from offer
            var request = new PurchaseOrder()
            {
                // Guid = payment.OrderId,
                UserId = userIdInt,
                OrderId = payment.OrderId,
                CardNumber = payment.CardNumber
            };

            // Send request to OrderManager and await response
            var response = await _clientPurchaseOrder.GetResponse<PurchaseOrderResult>(request);
            var result = response.Message;

            return Ok(result.Success);
        }
    }
}
