using ApiGateway.DataModels;
using ApiGateway.SignalR;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Shared.Contracts;

namespace ApiGateway.Consumers
{
    public class NotificationConsumer : IConsumer<OfferPurchased>, IConsumer<TransportUpdated>, IConsumer<HotelUpdated>, IConsumer<OfferBooked>, IConsumer<OfferDeleted>
    {
        private readonly ILogger<NotificationConsumer> _logger;
        private readonly IHubContext<SignalRMessenger> _hubContext;

        public NotificationConsumer(ILogger<NotificationConsumer> logger, IHubContext<SignalRMessenger> hubcontext)
        {
            _logger = logger;
            _hubContext = hubcontext;
        }

        public async Task Consume(ConsumeContext<OfferPurchased> context)
        {
            var notification = context.Message;
            _logger.LogInformation($"OfferPurchased received\n\tHotel: {notification.HotelId}\n\tTransportTo: {notification.TransportToId}\n\tTransportBack: {notification.TransportBackId}");
            await _hubContext.Clients.Group(notification.TransportToId.ToString()).SendCoreAsync("TransportToPurchased", new object[] {  notification.TransportToId });
            await _hubContext.Clients.Group(notification.TransportBackId.ToString()).SendCoreAsync("TransportBackPurchased", new object[] { notification.TransportBackId });
            await _hubContext.Clients.Group(notification.HotelId.ToString()).SendCoreAsync("HotelPurchased", new object[] { notification.HotelId });
        }

        public async Task Consume(ConsumeContext<HotelUpdated> context)
        {
            var notification = context.Message;
            _logger.LogInformation($"HotelUpdated received ({notification.Id})");
            await _hubContext.Clients.Group(notification.Id.ToString()).SendCoreAsync("GetHotelUpdate", new object[] { notification.Id });
        }

        public async Task Consume(ConsumeContext<TransportUpdated> context)
        {
            var notification = context.Message;
            _logger.LogInformation($"TransportUpdated received ({notification.Id})");
            await _hubContext.Clients.Group(notification.Id.ToString()).SendCoreAsync("GetTransportUpdate", new object[] { notification.Id });
        }

        public async Task Consume(ConsumeContext<OfferBooked> context)
        {
            var notification = context.Message;
            _logger.LogInformation($"OfferBooked received");
            OrderStatsCache.AddOffer(notification.Offer);
            // It should send update to all users in group
            await _hubContext.Clients.Group("preferences").SendCoreAsync("GetPreferencesUpdate", new[] {OrderStatsCache.Stats});
        }

        public async Task Consume(ConsumeContext<OfferDeleted> context)
        {
            var notification = context.Message;
            _logger.LogInformation($"OfferDeleted received");
            OrderStatsCache.RemoveOffer(notification.Offer);
            // It should send update to all users in group
            await _hubContext.Clients.Group("preferences").SendCoreAsync("GetPreferencesUpdate", new[] { OrderStatsCache.Stats });
        }
    }
}
