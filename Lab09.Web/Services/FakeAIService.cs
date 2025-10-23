namespace Lab09.Web.Services
{
    public class FakeAIService : IAiService
    {
        public async Task<string> SendMessageAsync(string userMessage)
        {
            return "Response from fake AI service";
        }
    }
}