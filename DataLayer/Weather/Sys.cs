﻿using Newtonsoft.Json;

namespace DataLayer
{
    public class Sys
    {
        [JsonProperty("message")]
        public double Message { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("sunrise")]
        public int Sunrise { get; set; }
        [JsonProperty("sunset")]
        public int Sunset { get; set; }
    }
}
