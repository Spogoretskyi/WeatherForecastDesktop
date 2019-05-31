using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataLayer
{
    public class BisList
    {
        [JsonProperty("dt")]
        public int Dt { get; set; }
        [JsonProperty("main")]
        public BisMainMulti Main { get; set; }
        [JsonProperty("weather")]
        public List<BisWeather> Weather { get; set; }
        [JsonProperty("clouds")]
        public BisClouds Clouds { get; set; }
        [JsonProperty("wind")]
        public BisWind Wind { get; set; }
        [JsonProperty("rain")]
        public BisRain Rain { get; set; }
        [JsonProperty("sys")]
        public BisSysMulti Sys { get; set; }
        [JsonProperty("dt_txt")]
        public string DtTxt { get; set; }
    }
}
