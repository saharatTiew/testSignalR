using System;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.AspNetCore.SignalR.Client;
// using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;

namespace signalr_poc.Controllers
{
    public class TestController
    {
        HubConnection connection;
        List<String> messageLists;
        public TestController()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5001/ChatHub")
                .Build();
            messageLists = new List<string>();
        }

        // public async Task<string> Start(string user, string message)
        // {   
        //     connection.On<string, string>("ReceiveMessage", (user, message) =>
        //     {
        //         this.Dispatcher.Invoke(() =>
        //         {
        //            var newMessage = $"{user}: {message}";
        //            messagesList.Items.Add(newMessage);
        //         });
        //     });
        //     await connection.StartAsync();
        //     return messageLists.First().ToString();
        // }
    }
}