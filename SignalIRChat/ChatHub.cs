using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalIRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            //Clients.All.hello();
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }
}