using System.Diagnostics;

namespace TheWorld.Services
{
    public class DebugMailService : IMailService
    {
        public void SendMail(string To, string From, string Subject, string Body)
        {
            Debug.WriteLine($"Sending Mail: To: {To} From: {From} Subject: {Subject}");
        }
    }
}
