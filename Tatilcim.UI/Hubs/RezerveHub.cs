using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Tatilcim.UI.Hubs
{
    public class RezerveHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void GetRezerve(int UserId, string OtelId)
        {
            Clients.User(OtelId);
        }
    }
}