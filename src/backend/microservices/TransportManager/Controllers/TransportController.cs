using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shared.DataModels.Offer;
using Shared.DataModels.Transport;
using TransportManager.Services;

namespace TransportManager.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TransportController : ControllerBase
    {

        private readonly ILogger<TransportController> _logger;
        private readonly TransportService _transportService;

        public TransportController(ILogger<TransportController> logger, TransportContext context)
        {
            _logger = logger;
            _transportService = new TransportService(context);
        }

        [HttpGet(Name = "GetTransports")]
        public IEnumerable<TransportDataModel> GetTransports()
        {
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][GetTransports]GetTransports called");
            var transports = _transportService.GetAllTransports();
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][GetTransports]GetTransports returns {transports.Count}");
            return transports;
        }

        [HttpGet(Name = "GetAllFilter")]
        public IEnumerable<TransportOffer> GetAllFilter([FromQuery] TransportOfferFilter transportOfferFilter)
        {
            _logger.LogInformation($"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][GetAllFilter]GetAllFilter called");
            var transports = _transportService.GetTransportOffers(transportOfferFilter);
            _logger.LogInformation($"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][GetAllFilter]GetAllFilter returns {transports.Count()}");
            return transports;
        }

        [HttpPost(Name = "AddTransport")]
        public void AddTransport([FromBody] TransportDataModel transport)
        {
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][AddTransport]AddTransport called");
            _transportService.AddTransport(transport);
        }

        [HttpPost(Name = "UpdateTransport")]
        public void UpdateTransport([FromBody] TransportDataModel transport)
        {
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][UpdateTransport]UpdateTransport called");
            _transportService.UpdateTransport(transport);
        }

        [HttpDelete("{id}", Name = "RemoveTransport")]
        public void RemoveTransport(int id)
        {
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][RemoveTransport]RemoveTransport called");
            _transportService.RemoveTransport(id);
        }

        [HttpPost(Name = "Reserve")]
        public ActionResult<Guid> Reserve([FromBody] TransportData data)
        {
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][Reserve]Reserve called");
            var result = _transportService.ReserveTransport(data.Id, data.NumberOfPersons);
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][Reserve]Reserve returns {result}");
            return result.Item2;
        }
        
        [HttpPost(Name = "Cancel")]
        public ActionResult<int> Cancel([FromBody] TransportData data)
        {
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][Cancel]Cancel called");
            var result = _transportService.CancelReservation(data.Id, data.NumberOfPersons, data.OrderId);
            _logger.LogInformation(
                $"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][Cancel]Cancel returns {result}");
            return result;
        }

        [HttpGet(Name = "GetAllLocations")]
        public IEnumerable<string> GetAllLocations()
        {
            _logger.LogInformation($"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][GetAllFilter]GetAllFilter called");
            var locations = _transportService.GetAllLocations();
            _logger.LogInformation($"[{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}][GetAllFilter]GetAllFilter returns {locations.Count()}");
            return locations;
        }
    }
}