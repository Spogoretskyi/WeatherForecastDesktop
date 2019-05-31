using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataLayer
{
    public class BisRootObject
    {
        [JsonProperty("cod")]
        public string Cod { get; set; }
        [JsonProperty("message")]
        public double Message { get; set; }
        [JsonProperty("cnt")]
        public int Cnt { get; set; }
        [JsonProperty("list")]
        public List<BisList> List { get; set; }
        [JsonProperty("city")]
        public BisCityOW City { get; set; }
    }
}
