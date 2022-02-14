using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using DemoApiTests.Helpers;

namespace DemoApiTests.Endpoints
{
    internal class GetNewsEndpoint
    {
        private const string apiBaseUrl = "https://coronavirus-smartable.p.rapidapi.com";
        private const string version = "v1";
        private const string endpoint = "news";
        private Dictionary<string, string> requiredHeaders;

        public GetNewsEndpoint()
        {
            requiredHeaders = new Dictionary<string, string>()
            {
                { "x-rapidapi-host", "coronavirus-smartable.p.rapidapi.com" },
                { "x-rapidapi-key", "ffc8dbc853msh589b88b8c9d6a94p1eef3ajsnbca19bcf48e7" },
            };
        }
        internal async Task<HttpResponseMessage> SendGetRequest(string region)
        {
            var uri = $"{apiBaseUrl}/{endpoint}/{version}/{region}/";
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            request.Headers.AddRange(requiredHeaders);
            var client = new HttpClient();

            return await client.SendAsync(request);
        }
    }
}
