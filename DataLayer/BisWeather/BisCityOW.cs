using System;
using Newtonsoft.Json;

namespace DataLayer
{
    public class BisCityOW : BisCity, IEquatable<BisCityOW>
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        public bool Equals(BisCityOW other)
        {
            if (other is null)
                return false;

            return this.Id == other.Id && this.Name == other.Name
                && this.Country == other.Country
                && this.Coord.Lat == other.Coord.Lat
                && this.Coord.Lon == other.Coord.Lon;
        }
        public override bool Equals(object obj) => Equals(obj as BisCityOW);
        public override int GetHashCode() => (Id).GetHashCode();
    }
}
