using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daishi.AMQP;

namespace MathMicroservice
{
    public class DoubleMathMicroservice : IMicroservice
    {
        const string _hostName = "localhost";
        const int _portNumber = 5672;
        const string _userName = "guest";
        const string _password = "guest";

        const string _inBoundQueue = "Math";
        const string _outBoundQueue = "MathResponse";

        private RabbitMQAdapter _adapter;
        private RabbitMQConsumerCatchAll _rabbitMQConsumerCatchAll;

        public void Init()
        {
            _adapter = RabbitMQAdapter.Instance;
            _adapter.Init(_hostName, _portNumber, _userName, _password, 50);

            _rabbitMQConsumerCatchAll = new RabbitMQConsumerCatchAll(_inBoundQueue, 10);
            _rabbitMQConsumerCatchAll.MessageReceived += OnMessageReceived;

            _adapter.Connect();
            _adapter.ConsumeAsync(_rabbitMQConsumerCatchAll);
        }

        public void OnMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            var input = Convert.ToInt32(e.Message);
            var result = input * 2;

            _adapter.Publish(result.ToString(), _outBoundQueue);
        }

        public void Shutdown()
        {
            if (_adapter == null)
            {
                return;
            }

            if (_rabbitMQConsumerCatchAll != null)
            {
                _adapter.StopConsumingAsync(_rabbitMQConsumerCatchAll);
            }

            _adapter.Disconnect();
        }
    }
}
