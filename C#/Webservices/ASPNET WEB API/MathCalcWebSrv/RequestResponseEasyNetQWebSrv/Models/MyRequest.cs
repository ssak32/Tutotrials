using EasyNetQ;

namespace RequestResponseEasyNetQWebSrv.Models
{
    [Queue("TestMessagesQueue", ExchangeName = "MyTestExchange")]
    public class MyRequest
    {
        public string Text { get; set; }
    }
}
