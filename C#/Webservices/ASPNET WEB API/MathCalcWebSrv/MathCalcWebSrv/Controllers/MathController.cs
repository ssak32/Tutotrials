using Daishi.AMQP;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace MathCalcWebSrv.Controllers
{
    public class MathController : ApiController
    {
        const string _outBoundQueue = "Math";
        const string _inBoundQueue = "MathResponse";

        public string GetDoubled(int id)
        {
            RabbitMQAdapter.Instance.Publish(id.ToString(), _outBoundQueue);

            string message;
            BasicDeliverEventArgs args;
            var responded = RabbitMQAdapter.Instance.TryGetNextMessage(_inBoundQueue, out message, out args, 5000);

            if (responded)
            {
                return message;
            }

            throw new HttpResponseException(HttpStatusCode.BadGateway);
        }

        public string GetSqrt(int id)
        {

            RabbitMQAdapter.Instance.Publish(id.ToString(), _outBoundQueue);

            string message;
            BasicDeliverEventArgs args;
            var responded = RabbitMQAdapter.Instance.TryGetNextMessage(_inBoundQueue, out message, out args, 5000);

            if (responded)
            {
                return message;
            }

            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://localhost/MathMicroservice/");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    // HTTP GET
            //    HttpResponseMessage response = client.GetAsync("api/math/" + id).Result;
            //    if (response.IsSuccessStatusCode)
            //    {
            //        string message;
            //        BasicDeliverEventArgs args;
            //        var responded = RabbitMQAdapter.Instance.TryGetNextMessage(_inBoundQueue, out message, out args, 5000);

            //        if (responded)
            //        {
            //            return message;
            //        }                    
            //    }
            //}

            throw new HttpResponseException(HttpStatusCode.BadGateway);
        }
    }
}
