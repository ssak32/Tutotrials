using EasyNetQ;

namespace RequestResponseEasyNetQWebSrv.Models
{
    [Queue("TestMessagesQueue", ExchangeName = "MyTestExchange")]
    public class MyResponse
    {
        public string Text { get; set; }
    }
}
