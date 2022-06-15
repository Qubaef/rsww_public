using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.HotelManager;
using Shared.DataModels.Offer;

namespace OfferGenerator.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OfferGeneratorTestController : ControllerBase
    {
        private IRequestClient<GetHotelOffers> _clientGetAllHotels;
        private IRequestClient<GetHotelById> _clientGetHotelById;
        private readonly ILogger<OfferGeneratorTestController> _logger;

        public OfferGeneratorTestController(IRequestClient<GetHotelOffers> clientGetAllHotels, IRequestClient<GetHotelById> clientGetHotelById, ILogger<OfferGeneratorTestController> logger)
        {
            _clientGetAllHotels = clientGetAllHotels;
            _clientGetHotelById = clientGetHotelById;
            _logger = logger;
        }

        [HttpGet]
        public async Task<GetHotelOffersResult> GetAllHotels()
        {
            // var request = new GetHotelOffers();
            // var response = await _clientGetAllHotels.GetResponse<GetHotelOffersResult>(request);
            // var result = response.Message;
            var hotelOffers = new List<HotelOffer>();
            var result = new GetHotelOffersResult(hotelOffers);
            return result;
        }

        [HttpGet]
        public async Task<GetHotelByIdResult> GetHotelById([FromQuery] int HotelId)
        {
            var request = new GetHotelById { HotelId = HotelId };
            var response = await _clientGetHotelById.GetResponse<GetHotelByIdResult>(request);
            var result = response.Message;
            return result;
        }
    }
}