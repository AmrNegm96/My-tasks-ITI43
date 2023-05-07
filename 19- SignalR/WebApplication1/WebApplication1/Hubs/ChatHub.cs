using Microsoft.AspNetCore.SignalR;
using System.Xml.Serialization;

namespace WebApplication1.Hubs
{
    public class ChatHub : Hub
    {
        public void NewMsg(string name , string msg)
        {
            
            ///recieve from client
            ///logic
            ///notify
            Clients.All.SendAsync("NotifyNewMessage" , name , msg);
            ///logic
            ///logic
            
        }
        //public override Task OnConnectedAsync()
        //{
        //    //any logic
        //}
    }
}
