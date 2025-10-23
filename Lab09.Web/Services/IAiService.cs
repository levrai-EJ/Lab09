namespace Lab09.Web.Services
{
    public interface IAiService
    {
        Task<string> SendMessageAsync(string userMessage);
    }
}