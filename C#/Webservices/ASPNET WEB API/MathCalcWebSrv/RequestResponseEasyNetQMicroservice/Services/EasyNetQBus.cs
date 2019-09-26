using EasyNetQ;
using RequestResponseEasyNetQMicroservice.Interfaces;
using RequestResponseEasyNetQMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestResponseEasyNetQMicroservice.Services
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

            bus.Respond<MyRequest, MyResponse>(_request => new MyResponse { Text = "Server responding to " + _request.Text });

            //bus.RespondAsync<MyRequest, MyResponse>(request =>
            //    Task.Factory.StartNew(() =>
            //    {
            //        Response(request)
            //    }
            //);
        }

        public string Response(string request)
        {
            //bus.Respond<MyRequest, MyResponse>(_request => new MyResponse { Text = "Server responding to " + _request.Text });            

            return string.Empty;
        }
    }
}
