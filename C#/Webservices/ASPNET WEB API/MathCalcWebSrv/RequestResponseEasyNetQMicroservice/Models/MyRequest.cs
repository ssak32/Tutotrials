using EasyNetQ;

namespace RequestResponseEasyNetQMicroservice.Models
{
    [Queue("TestMessagesQueue", ExchangeName = "MyTestExchange")]
    public class MyRequest
    {
        public string Text { get; set; }
    }
}
