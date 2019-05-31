using Newtonsoft.Json;

namespace DataLayer
{
    public class BisCoord
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }
        [JsonProperty("lat")]
        public double Lat { get; set; }
    }
}
