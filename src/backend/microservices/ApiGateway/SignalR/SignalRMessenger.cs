using ApiGateway.DataModels;
using Microsoft.AspNetCore.SignalR;

namespace ApiGateway.SignalR
{
    public class SignalRMessenger : Hub
    {
        private readonly ILogger<SignalRMessenger> _logger;

        public SignalRMessenger(ILogger<SignalRMessenger> logger)
        {
            _logger = logger;
        }

        public async Task SendPreferenceUpdate()
        {
            await Clients.Group("preference").SendAsync("PreferenceUpdate", OrderStatsCache.Stats);
        }

        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }
        
        public async Task RemoveFromGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        }
    }

}
