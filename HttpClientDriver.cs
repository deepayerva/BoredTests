using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BoredAPITesting
{
    public class HttpClientDriver : IDisposable
    {
        private readonly HttpClient _restClient = null;
        public HttpClientDriver()
        {
            _restClient = CreateAPIHttpClient();
        }

        public HttpClient CreateAPIHttpClient()
        {
            var handler = new HttpClientHandler();
            var httpClient = new HttpClient(handler);
            return httpClient;
        }

        public async Task<dynamic> ExecuteGetRequest(HttpClient httpClient, string requestUrl)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            request.Headers.Add("Accept", "application/json, text/plain, */*");
            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responsebody = await response.Content.ReadAsStringAsync();
            return responsebody;
        }

        public async Task<T> GetDeserializedContent<T>(dynamic response)
        {
            T dataObject = JsonConvert.DeserializeObject<T>(response);
            return dataObject;
        }

        public void Dispose()
        {
            _restClient?.Dispose();
        }
    }
}

