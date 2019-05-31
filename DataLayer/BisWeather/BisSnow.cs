using Newtonsoft.Json;

namespace DataLayer
{
    public class BisSnow
    {
        [JsonProperty("snow")]
        public double SnowProp { get; set; }
    }
}
