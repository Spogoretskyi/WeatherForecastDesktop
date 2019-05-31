using Newtonsoft.Json;

namespace DataLayer
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }
}
