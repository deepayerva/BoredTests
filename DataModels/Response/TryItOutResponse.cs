using Newtonsoft.Json;

namespace BoredAPITesting.DataModels.Response
{
    public class TryItOutResponse
    {
        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("accessibility")]
        public string Accessibility { get; set; }
      
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("participants")]
        public string Participants { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }    
    }
}
