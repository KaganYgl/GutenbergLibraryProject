namespace gutenberg.Controllers
{
    public interface IHttpClientWrapper
    {
        Task<HttpResponseMessage> GetAsync(string requestUri);
        // Add other necessary methods here
    }

}
