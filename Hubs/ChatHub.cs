using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Pop_Simona_Lab2M.Hubs
{
    public class ChatHub : Hub
    {
        [Authorize]
        public async Task SendMessage(string user, string message)
        {
            string datetime = DateTime.Now.ToString();
            await Clients.All.SendAsync("ReceiveMessage", Context.User.Identity.Name, message, datetime);
        }
    }
    
}
