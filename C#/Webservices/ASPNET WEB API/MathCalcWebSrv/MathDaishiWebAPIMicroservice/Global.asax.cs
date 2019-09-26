using Daishi.AMQP;
using MathDaishiWebAPIMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace MathDaishiWebAPIMicroservice
{
    public class WebApiApplication : System.Web.HttpApplication
    {
            //const string _hostName = "localhost";
            //const int _portNumber = 5672;
            //const string _userName = "guest";
            //const string _password = "guest";
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            this.ConfigureRabbitMQ();
        }

        private void ConfigureRabbitMQ()
        {
            new SquareRootMathMicroservice().Init();

            //#region Daishi RabbitMQAdapter Init
            //var adapter = RabbitMQAdapter.Instance;
            //adapter.Init(_hostName, _portNumber, _userName, _password, 100);
            //adapter.Connect();
            //#endregion
        }
    }
}
