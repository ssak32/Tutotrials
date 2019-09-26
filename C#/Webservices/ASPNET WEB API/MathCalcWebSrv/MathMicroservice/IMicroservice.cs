using Daishi.AMQP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMicroservice
{
    interface IMicroservice
    {
        void Init();
        void OnMessageReceived(object sender, MessageReceivedEventArgs e);
        void Shutdown();
    }
}
