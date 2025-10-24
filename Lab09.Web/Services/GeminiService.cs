using System;
using System.Threading.Tasks;
using OpenAI;
using OpenAI.Chat;
using System.ClientModel;

namespace Lab09.Web.Services
{
    public class GeminiService : IAiService
    {
        private readonly ChatClient _client;

        public GeminiService()
        {
            _client = new ChatClient(
                model: "gemini-2.0-flash",
                credential: new ApiKeyCredential(Environment.GetEnvironmentVariable("GEMINI_API_KEY")),
                options: new OpenAIClientOptions()
                {
                    Endpoint = new Uri("https://generativelanguage.googleapis.com/v1beta/openai/")
                }
            );
        }

        public async Task<string> SendMessageAsync(string userMessage)
        {
            ClientResult<ChatCompletion> completion = await _client.CompleteChatAsync(userMessage);
            string response = completion.Value.Content[0].Text;
            return response;
        }
    }
}