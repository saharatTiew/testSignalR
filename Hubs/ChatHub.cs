using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
using signalr_poc.Models;

namespace signalr_poc.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user,message);
        }
    }
}