
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace MonicaEdaChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        
        public async Task SendMessagetoCaller(string user, string message)
        {
            await Clients.Others.SendAsync("ReceiveMessage", user, message);
        }
            
    }
}

