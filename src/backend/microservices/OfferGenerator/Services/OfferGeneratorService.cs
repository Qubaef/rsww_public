using MassTransit;
using MongoDB.Driver;
using Shared.Contracts.HotelManager;
using Shared.Contracts.OfferManager;
using Shared.Contracts.TransportManager;
using Shared.DataModels.Offer;
using Shared.DataModels.Transport;

namespace OfferGenerator.Services;

public class OfferGeneratorService
{
    private readonly ILogger<OfferGeneratorService> _logger;
    private readonly IRequestClient<GetTransportOffers> _clientGetTransportOffers;
    private readonly IRequestClient<GetHotelOffers> _clientGetHotelOffers;
    private readonly IRequestClient<IsTransportOfferAvailable> _clientIsTransportOfferAvailable;
    private readonly IRequestClient<IsHotelOfferAvailable> _clientIsHotelOfferAvailable;

    private readonly IRequestClient<RefreshTransportOffer> _clientRefreshTransportOffer;
    private readonly IRequestClient<RefreshHotelOffer> _clientRefreshHotelOffer;


    public OfferGeneratorService(ILogger<OfferGeneratorService> logger, IRequestClient<GetTransportOffers> clientGetTransportOffers, IRequestClient<GetHotelOffers> clientGetHotelOffers, IRequestClient<IsTransportOfferAvailable> clientIsTransportOfferAvailable, IRequestClient<IsHotelOfferAvailable> clientIsHotelOfferAvailable, IRequestClient<RefreshTransportOffer> clientRefreshTransportOffer, IRequestClient<RefreshHotelOffer> clientRefreshHotelOffer)
    {
        _clientGetHotelOffers = clientGetHotelOffers;
        _clientGetTransportOffers = clientGetTransportOffers;
        _logger = logger;
        _clientIsTransportOfferAvailable = clientIsTransportOfferAvailable;
        _clientIsHotelOfferAvailable = clientIsHotelOfferAvailable;
        _clientRefreshTransportOffer = clientRefreshTransportOffer;
        _clientRefreshHotelOffer = clientRefreshHotelOffer;
    }

    private static MealOffer RandomMealOffer(HotelOffer offer)
    {
        Random _R = new Random(offer.HotelId);
        var v = Enum.GetValues(typeof(MealOfferType));
        var mealOfferType = (MealOfferType)v.GetValue(_R.Next(v.Length));
        var mealOfferPrice = (int)mealOfferType * 0.05 * offer.Price;

        return new MealOffer
        {
            Type = mealOfferType,
            Price = mealOfferPrice
        };
    }

    public async Task<bool> IsOfferAvailable(Offer offer)
    {
        var IsTransportToOfferAvailableRequest = new IsTransportOfferAvailable(offer.TransportTo);
        var IsTransportToOfferAvailableResponse = _clientIsTransportOfferAvailable.GetResponse<IsTransportOfferAvailableResult>(IsTransportToOfferAvailableRequest);

        var IsTransportBackOfferAvailableRequest = new IsTransportOfferAvailable(offer.TransportBack);
        var IsTransportBackOfferAvailableResponse = _clientIsTransportOfferAvailable.GetResponse<IsTransportOfferAvailableResult>(IsTransportBackOfferAvailableRequest);

        var IsHotelOfferAvailableRequest = new IsHotelOfferAvailable(offer.Hotel);
        var IsHotelOfferAvailableResponse = _clientIsHotelOfferAvailable.GetResponse<IsHotelOfferAvailableResult>(IsHotelOfferAvailableRequest);

        var IsTransportToOfferAvailable = (await IsTransportToOfferAvailableResponse).Message.IsAvailable;
        if (!IsTransportToOfferAvailable)
        {
            return false;
        }

        var IsTransportBackOfferAvailable = (await IsTransportBackOfferAvailableResponse).Message.IsAvailable;
        if (!IsTransportBackOfferAvailable)
        {
            return false;
        }

        var IsHotelOfferAvailable = (await IsHotelOfferAvailableResponse).Message.IsAvailable;
        if (!IsHotelOfferAvailable)
        {
            return false;
        }
        
        return true;
    }

    public async Task<Offer?> RefreshOffer(Offer offer)
    {
        var RefreshTransportToOfferRequest = new RefreshTransportOffer(offer.TransportTo);
        var RefreshTransportToOfferResponse = _clientRefreshTransportOffer.GetResponse<RefreshTransportOfferResult>(RefreshTransportToOfferRequest);

        var RefreshTransportBackOfferRequest = new RefreshTransportOffer(offer.TransportBack);
        var RefreshTransportBackOfferResponse = _clientRefreshTransportOffer.GetResponse<RefreshTransportOfferResult>(RefreshTransportBackOfferRequest);

        var RefreshHotelOfferRequest = new RefreshHotelOffer(offer.Hotel);
        var RefreshHotelOfferResponse = _clientRefreshHotelOffer.GetResponse<RefreshHotelOfferResult>(RefreshHotelOfferRequest);

        
        var TransportToRefreshedOffer = (await RefreshTransportToOfferResponse).Message.TransportOffer;
        if (TransportToRefreshedOffer == null)
        {
            return null;
        }

        var TransportBackRefreshedOffer = (await RefreshTransportBackOfferResponse).Message.TransportOffer;
        if (TransportBackRefreshedOffer == null)
        {
            return null;
        }

        var HotelRefreshedOffer = (await RefreshHotelOfferResponse).Message.HotelOffer;
        if (HotelRefreshedOffer == null)
        {
            return null;
        }

        return new Offer(
                HotelRefreshedOffer,
                TransportToRefreshedOffer,
                TransportBackRefreshedOffer,
                offer.MealOffer,
                offer.Discount
        );
    }

    public async Task<IEnumerable<Offer>> GetOffers(OfferFilter offerFilter)
    {
        List<Offer> generatedOffers = new List<Offer>();

        if (offerFilter.DepartDate.Date <= DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local).Date)
            return generatedOffers;

        if (offerFilter.DepartDate.Date >= offerFilter.ReturnDate.Date)
            return generatedOffers;

        // Requirements 1 and 2
        // Note that we are assuming that offers HAVE TO be filtered to display anything

        offerFilter.TransportTypes = new List<TransportType> { TransportType.Bus, TransportType.Plane, TransportType.Train };

        var transportToFilter = new TransportOfferFilter(offerFilter, TransportDirection.To);
        var transportBackFilter = new TransportOfferFilter(offerFilter, TransportDirection.Back);
        var hotelFilter = new HotelOfferFilter(offerFilter);

        var transportToRequest = new GetTransportOffers(transportToFilter);
        var transportToResponse = _clientGetTransportOffers.GetResponse<GetTransportOffersResult>(transportToRequest);

        var TransportBackRequest = new GetTransportOffers(transportBackFilter);
        var transportBackResponse = _clientGetTransportOffers.GetResponse<GetTransportOffersResult>(TransportBackRequest);

        var hotelsRequest = new GetHotelOffers(hotelFilter);
        var hotelsResponse = _clientGetHotelOffers.GetResponse<GetHotelOffersResult>(hotelsRequest);



        var hotelOffers = (await hotelsResponse).Message.HotelOffers.OrderBy(x => x.Price);
        if (!hotelOffers.Any())
        {
            return generatedOffers;
        }

        var transportToOffers = (await transportToResponse).Message.Transports.OrderBy(x => x.Price);
        if (!transportToOffers.Any())
        {
            return generatedOffers;
        }

        var transportBackOffers = (await transportBackResponse).Message.Transports.OrderBy(x => x.Price);
        if (!transportBackOffers.Any())
        {
            return generatedOffers;
        }

        var daysLeft = 10 - (hotelOffers.First().From.Date - DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local).Date).Days;
        var discount = daysLeft > 0 ? (1.0 - (daysLeft * 0.025)) : 1.0;
        var randgen = new Random();
        foreach (var hotelOffer in hotelOffers)
        {
            var generatedOffer = new Offer(
                hotelOffer,
                transportToOffers.ElementAt(randgen.Next(0, transportToOffers.Count())),
                transportBackOffers.ElementAt(randgen.Next(0, transportBackOffers.Count())),
                RandomMealOffer(hotelOffer),
                discount
            );
            generatedOffers.Add(generatedOffer);
        }

        return generatedOffers;
    }

}
