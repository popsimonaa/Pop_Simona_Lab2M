using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pop_Simona_Lab2M.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            string datetime = DateTime.Now.ToString();
            await Clients.All.SendAsync("ReceiveMessage", user, message, datetime);
        }
    }
    
}
