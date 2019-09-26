using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Receiver_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constant Strings
            const string _queueName = "myqueue";
            const string _exchange = "myexchange";
            const string _hostName = "localhost";
            const string _userName = "guest";
            const string _password = "guest";
            #endregion

            var factory = new ConnectionFactory() { HostName = _hostName, UserName = _userName, Password = _password };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                #region Configuring Exchange & Queue. Skips if both already exists.
                channel.QueueDeclare(queue: _queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
                Console.WriteLine("Queue created");

                channel.ExchangeDeclare(_exchange, ExchangeType.Fanout);
                Console.WriteLine("Exchange created");

                channel.QueueBind(_queueName, _exchange, "");
                Console.WriteLine("Exchange '" + _exchange + "' and Queue '" + _queueName + " are now bounded");
                #endregion

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine(" [x] Received {0}", message);
                };
                channel.BasicConsume(queue: "myqueue", noAck: true, consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
