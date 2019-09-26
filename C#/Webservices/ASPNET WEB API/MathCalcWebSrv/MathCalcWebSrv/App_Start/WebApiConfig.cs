using Daishi.AMQP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MathCalcWebSrv
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            const string _hostName = "localhost";
            const int _portNumber = 5672;
            const string _userName = "guest";
            const string _password = "guest";

            // Web API configuration and services
            #region RabbitMQAdapter Init
            var adapter = RabbitMQAdapter.Instance;
            adapter.Init(_hostName, _portNumber, _userName, _password, 100);
            adapter.Connect();            
            #endregion


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
