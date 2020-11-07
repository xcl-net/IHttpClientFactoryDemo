using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IHttpClientFactoryDemo
{

    public class SecondHttpService : ISecondHttpService
    {
        private readonly IHttpClientFactory _httpClient;


        public SecondHttpService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Get()
        {
            var hash = _httpClient.GetHashCode();
            var client = _httpClient.CreateClient();
            client.BaseAddress = new Uri("https://www.jd.com/");

            var html = await client.GetStringAsync("/");
            return $"SecondHttpService IHttpClientFactory hash:{hash} {Environment.NewLine } {Environment.NewLine } {html}";
        }
    }
}
