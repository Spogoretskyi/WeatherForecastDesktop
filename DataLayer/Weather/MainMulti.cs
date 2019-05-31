using Newtonsoft.Json;

namespace DataLayer
{
    public class MainMulti : Main
    {
        [JsonProperty("temp_kf")]
        public double TempKf { get; set; }
    }
}
