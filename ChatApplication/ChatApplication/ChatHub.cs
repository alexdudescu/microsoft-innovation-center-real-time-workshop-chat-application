using Microsoft.AspNet.SignalR;

namespace ChatApplication
{
    public class ChatHub : Hub
    {
        public void Send(string originatorUser, string message)
        {
            Clients.All.messageReceived(originatorUser, message);
        }
    }
}