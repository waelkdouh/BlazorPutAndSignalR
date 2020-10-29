using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorSignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, bool approved)
        {
            if (approved)
            {
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, "refuse");
                await Groups.AddToGroupAsync(Context.ConnectionId, "approved");
                await Clients.Group("approved").SendAsync("ReceiveMessage", user, message, approved);
            }
            else
            {
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, "approved");
                await Groups.AddToGroupAsync(Context.ConnectionId, "refuse");
                await Clients.Group("refuse").SendAsync("ReceiveMessage", user, message, approved);
            }
        }
    }
}
