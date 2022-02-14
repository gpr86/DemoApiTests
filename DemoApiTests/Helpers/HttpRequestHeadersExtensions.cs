using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DemoApiTests.Helpers
{
    internal static class HttpRequestHeadersExtensions
    {
        public static void AddRange(this HttpRequestHeaders headersCollection, IDictionary<string, string> headersToAdd)
        {
            foreach (var header in headersToAdd)
            {
                headersCollection.Add(header.Key, header.Value);
            }
        }
    }
}
