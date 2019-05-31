using Newtonsoft.Json;

namespace DataLayer
{
    public class BisCurrentWeather
    {
        [JsonProperty("coord")]
        public BisCoord Coord { get; set; }
        [JsonProperty("weather")]
        public BisWeather[] Weather { get; set; }
        [JsonProperty("base")]
        public string Base { get; set; }
        [JsonProperty("main")]
        public BisMain Main { get; set; }
        [JsonProperty("wind")]
        public BisWind Wind { get; set; }
        [JsonProperty("clouds")]
        public BisClouds Clouds { get; set; }
        [JsonProperty("dt")]
        public int Dt { get; set; }
        [JsonProperty("sys")]
        public BisSys Sys { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("cod")]
        public int Cod { get; set; }
    }
}
