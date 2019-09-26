using EasyNetQ;

namespace RequestResponseEasyNetQMicroservice.Models
{
    [Queue("TestMessagesQueue", ExchangeName = "MyTestExchange")]
    public class MyResponse
    {
        public string Text { get; set; }
    }
}
