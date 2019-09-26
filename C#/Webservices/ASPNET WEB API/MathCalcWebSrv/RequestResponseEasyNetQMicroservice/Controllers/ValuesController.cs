using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RequestResponseEasyNetQMicroservice.Interfaces;

namespace RequestResponseEasyNetQMicroservice.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        IRabbitBus _rabbitBus;

        public ValuesController(IRabbitBus RabbitBus)
        {
            _rabbitBus = RabbitBus;
            _rabbitBus.Init();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _rabbitBus.Response(string.Empty);
        }
    }
}
