using Daishi.AMQP;
using MathDaishiWebAPIMicroservice.Models;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MathDaishiWebAPIMicroservice.Controllers
{
    public class MathController : ApiController
    {
        public MathController()
        {
            new SquareRootMathMicroservice().Init();
        }

        public string Get(int id)
        {
            //new SquareRootMathMicroservice().Init();

            return string.Empty;
        }
    }
}
