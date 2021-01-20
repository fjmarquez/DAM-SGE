using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _11SignalRChat.DataObjects;
using Microsoft.AspNet.SignalR;

namespace _11SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(/*string name, string message*/ChatMessage chatMessage)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(/*name, message*/ chatMessage);
        }
    }
}