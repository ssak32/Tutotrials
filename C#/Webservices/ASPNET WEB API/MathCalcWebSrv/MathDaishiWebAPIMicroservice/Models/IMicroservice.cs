using Daishi.AMQP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDaishiWebAPIMicroservice.Models
{
    interface IMicroservice
    {
        void Init();
        void OnMessageReceived(object sender, MessageReceivedEventArgs e);
        void Shutdown();
    }
}
