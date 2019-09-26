using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RequestResponseEasyNetQWebSrv.Interfaces;

namespace RequestResponseEasyNetQWebSrv.Controllers
{
    [Route("api/[controller]")]
    public class SimpleController : Controller
    {
        private IRabbitBus _rabbitBus;

        public SimpleController(IRabbitBus RabbitBus)
        {
            _rabbitBus = RabbitBus;
            _rabbitBus.Init();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _rabbitBus.Request("Hello Server");
        }
    }
}
