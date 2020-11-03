using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication4.Services
{
    public class MyHttpService : IMyHttpService
    {
        private readonly IHttpClientFactory _httpClient;

        public MyHttpService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Get()
        {
            var hash = this.GetHashCode();
            var client = _httpClient.CreateClient();
            var html = await client.GetStringAsync("http://www.baidu.com");
            return $"hash:{hash} {Environment.NewLine } {Environment.NewLine } {html}";
        }
    }
}
