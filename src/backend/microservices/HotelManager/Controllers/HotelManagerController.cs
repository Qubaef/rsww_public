using HotelManager.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.DataModels.Hotel;
using Shared.DataModels.Offer;

namespace HotelManager.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HotelManagerController : ControllerBase
    {
        private readonly HotelServices _hotelService;

        private readonly ILogger<HotelManagerController> _logger;

        public HotelManagerController(ILogger<HotelManagerController> logger, HotelServices hotelServices)
        {
            _logger = logger;
            _hotelService = hotelServices;
        }

        [HttpGet(Name = "GetHotels")]
        public IEnumerable<HotelStaticData> GetHotels()
        {
            // logging scheme [timestamp] [url] [message]
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][GetHotels]GetHotels called");
            var hotels = _hotelService.GetAllHotelsFull();
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][GetHotels]" +
                $"GetHotels returned {hotels.Count} hotels");
            return hotels;
        }

        [HttpGet(Name = "GetHotelsMinimal")]
        public IEnumerable<int> GetHotelsMinimal()
        {
            // logging scheme [timestamp] [url] [message]
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][GetHotels]GetHotels called");
            var hotels = _hotelService.GetAllHotelsMinimal();
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][GetHotels]" +
                $"GetHotels returned {hotels.Count} hotels");
            return hotels;
        }

        [HttpPost(Name = "AddHotel")]
        public void CreateHotel([FromBody] HotelStaticData hotel)
        {
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][AddHotel]" +
                $"AddHotel called with id {hotel.Id}");
            _hotelService.CreateHotel(hotel);
        }

        [HttpDelete(Name = "RemoveHotel")]
        public void RemoveHotel([FromBody] int id)
        {
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}]" +
                $"[RemoveHotel]RemoveHotel called with id {id}");
            _hotelService.RemoveHotel(id);
        }

        [HttpGet(Name = "GetHotelOffers")]
        public IEnumerable<HotelOffer> GetHotelOffers([FromQuery] HotelOfferFilter filter)
        {
            return _hotelService.GetHotelOffers(filter);
        }

        [HttpPost(Name = "ReserveRoom")]
        public RoomReservation ReserveRoom([FromBody] HotelOffer reservation)
        {
            return _hotelService.ReserveOffer(reservation);
        }

        [HttpPost(Name = "CancelReservation")]
        public void CancelReservation([FromBody] RoomReservation reservation)
        {
            _hotelService.CancelReservation(reservation);
        }

        [HttpGet(Name = "GetRoomReservations")]
        public IEnumerable<RoomReservation> GetRoomReservations()
        {
            return _hotelService.GetRoomReservations();
        }

    }


}