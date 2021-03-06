﻿using Newtonsoft.Json;

namespace DataLayer
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }
        [JsonProperty("pressure")]
        public double Pressure { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("temp_min")]
        public double TempMin { get; set; }
        [JsonProperty("temp_max")]
        public double TempMax { get; set; }
        [JsonProperty("sea_level")]
        public double SeaLevel { get; set; }
        [JsonProperty("grnd_level")]
        public double GrndLevel { get; set; }
    }
}
