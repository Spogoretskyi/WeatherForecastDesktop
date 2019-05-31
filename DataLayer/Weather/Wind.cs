using Newtonsoft.Json;

namespace DataLayer
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
        [JsonProperty("deg")]
        public string Deg { get; set; }
    }
}
