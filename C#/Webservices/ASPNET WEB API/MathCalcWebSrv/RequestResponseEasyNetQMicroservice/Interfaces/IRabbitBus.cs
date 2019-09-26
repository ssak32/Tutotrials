namespace RequestResponseEasyNetQMicroservice.Interfaces
{
    public interface IRabbitBus
    {
        void Init();
        string Response(string request);
    }
}
