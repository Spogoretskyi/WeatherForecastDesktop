using Newtonsoft.Json;

namespace DataLayer
{
    public class Snow
    {
        [JsonProperty("snow")]
        public double SnowProp { get; set; }
    }
}
