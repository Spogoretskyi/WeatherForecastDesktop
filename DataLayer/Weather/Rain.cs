using Newtonsoft.Json;

namespace DataLayer
{
    public class Rain
    {
        [JsonProperty("rain")]
        public double RainProp { get; set; }
    }
}
