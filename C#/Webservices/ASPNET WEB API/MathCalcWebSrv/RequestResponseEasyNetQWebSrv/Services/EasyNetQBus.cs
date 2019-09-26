using EasyNetQ;
using RequestResponseEasyNetQWebSrv.Interfaces;
using RequestResponseEasyNetQWebSrv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestResponseEasyNetQWebSrv.Services
{
    public class EasyNetQBus : IRabbitBus
    {
        const string _hostName = "localhost";
        const int _portNumber = 15672;
        const string _userName = "guest";
        const string _password = "guest";

        IBus bus;

        public void Init()
        {
            #region EasyNQ Connection
            //var bus = RabbitHutch.CreateBus("host=" + _hostName + ":" + _portNumber + ";username=" + _userName + ";password=" + _password + "");
            bus = RabbitHutch.CreateBus("host=" + _hostName);
            #endregion
        }

        public string Request(string request)
        {
            var myRequest = new MyRequest { Text = request };
            var response = bus.Request<MyRequest, MyResponse>(myRequest);

            return response.Text;
        }
    }
}
