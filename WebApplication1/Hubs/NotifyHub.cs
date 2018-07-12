using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebApplication1
{
    public class NotifyHub : Hub
    {
        public void SendMessage(string name, string message)
        {
            Clients.All.NotifyPush(name, message);
        }
    }
}