using Newtonsoft.Json;

namespace DataLayer
{
    public class BisRain
    {
        [JsonProperty("rain")]
        public double RainProp { get; set; }
    }
}
