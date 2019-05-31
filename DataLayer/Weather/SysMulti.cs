using Newtonsoft.Json;

namespace DataLayer
{
    public class SysMulti
    {
        [JsonProperty("pod")]
        public string Pod { get; set; }
    }
}
