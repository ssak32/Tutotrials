using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestResponseEasyNetQWebSrv.Interfaces
{
    public interface IRabbitBus
    {
        void Init();
        string Request(string request);
    }
}
