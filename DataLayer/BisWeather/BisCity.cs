using Newtonsoft.Json;

namespace DataLayer
{
    public abstract class BisCity
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("coord")]
        public BisCoord Coord { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
