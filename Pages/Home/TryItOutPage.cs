using BoredAPITesting.DataModels.Response;
using System.Threading.Tasks;

namespace BoredAPITesting.Pages.Home
{
    public static class TryItOutPage
    {
        public async static Task<dynamic> RequestResponse(string requestUrl)
        {
            var restClientDriver = new HttpClientDriver();
            var client = restClientDriver.CreateAPIHttpClient();
            var response = await restClientDriver.ExecuteGetRequest(client, requestUrl);
            var deserializedContent = await restClientDriver.GetDeserializedContent<TryItOutResponse>(response);
            return deserializedContent;
        }   
    }
}