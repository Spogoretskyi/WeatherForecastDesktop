using Newtonsoft.Json;

namespace DataLayer
{
    public class BisMainMulti : BisMain
    {
        [JsonProperty("temp_kf")]
        public double TempKf { get; set; }
    }
}
