using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Repositories;
using Newtonsoft.Json;

namespace WeatherForecastConsole
{
    class Program
    {
        private static IEnumerable<CityOW> Test()
        {
            var obj = new List<CityOW>
            {
                new CityOW()
                {
                    Id = 2,
                    Country = "1",
                    Name = "1",
                    Coord = new Coord() {Lon = 0, Lat = 0}
                },
                new CityOW()
                {
                    Id = 3,
                    Country = "2",
                    Name = "1",
                    Coord = new Coord() {Lon = 1, Lat = 1}

                },
                new CityOW()
                {
                    Id = 4,
                    Country = "ttttt",
                    Name = "ttttt",
                    Coord = new Coord() {Lon = 2.5555, Lat = 3.5555555}
                }
            };
            return obj;
        }
       static void Main(string[] args)
       { 


            IEntityService<BisCityOW, BisCurrentWeather, BisRootObject> bisWeatherService = new BisWeatherOWService();
            Console.WriteLine();

            var t = Test();

            var obj = JsonConvert.SerializeObject(t);

            Console.WriteLine(obj);

            var test = bisWeatherService.GetCities("Odessa");

            foreach (var item in test)
            {
                Console.WriteLine($"City --> {item.Name}\nLat = {item.Coord.Lat}\tLon = {item.Coord.Lat}\nCountry --> {item.Country}");  
            }


       }
    }
}
