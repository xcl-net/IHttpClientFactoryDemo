using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IHttpClientFactoryDemo
{
    public class FirstHttpService : IFirstHttpService
    {
        private readonly IHttpClientFactory _httpClient;

        public FirstHttpService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Get()
        {
            var hash = _httpClient.GetHashCode();

            var client = _httpClient.CreateClient();
            client.BaseAddress = new Uri("http://www.baidu.com");

            var html = await client.GetStringAsync("/");
            return $"FirstHttpService IHttpClientFactory hash:{hash} {Environment.NewLine } {Environment.NewLine } {html}";
        }
    }
}
