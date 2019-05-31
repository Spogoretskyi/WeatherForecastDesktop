using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Repository;

namespace DataLayer.Repositories
{
    public class BisWeatherOWService : IEntityService<BisCityOW, BisCurrentWeather, BisRootObject> 
    {
        IMapper mapper;
        IGenericRepository<CityOW, CurrentWeather, RootObject> weatherRepository = new OwRepository(new DataContext.DataWeatherContext<CityOW, CurrentWeather, RootObject>());
        public BisWeatherOWService()
        {
            // City
            var configCity = new MapperConfiguration(c => c.CreateMap<CityOW, BisCityOW>());
            mapper = configCity.CreateMapper();
            var configCiryReverse = new MapperConfiguration(c => c.CreateMap<BisCityOW, CityOW>());
            mapper = configCiryReverse.CreateMapper();

            // CurrentWeather
            var configCurrentWeather = new MapperConfiguration(c => c.CreateMap<CurrentWeather, BisCurrentWeather>());
            mapper = configCurrentWeather.CreateMapper();
            var configCurrentWeatherReverse = new MapperConfiguration(c => c.CreateMap<BisCurrentWeather, CurrentWeather>());
            mapper = configCurrentWeatherReverse.CreateMapper();

            // WeatherForecast
            var configWeatherForecast = new MapperConfiguration(c => c.CreateMap<RootObject, BisRootObject>());
            mapper = configWeatherForecast.CreateMapper();
            var cconfigWeatherForecastReverse = new MapperConfiguration(c => c.CreateMap<BisRootObject, RootObject>());
            mapper = cconfigWeatherForecastReverse.CreateMapper();
        }

        IEnumerable<BisRootObject> IEntityService<BisCityOW, BisCurrentWeather, BisRootObject>.Forecfast(int id)
        {
            return weatherRepository.Forecfast(id).Select(o => mapper.Map<BisRootObject>(o));
        }

        IEnumerable<BisCityOW> IEntityService<BisCityOW, BisCurrentWeather, BisRootObject>.GetCities(string name)
        {
            return weatherRepository.GetCities(name).Select(o => mapper.Map<BisCityOW>(name));
        }

        BisCurrentWeather IEntityService<BisCityOW, BisCurrentWeather, BisRootObject>.Weather(int id)
        {
            return mapper.Map<BisCurrentWeather>(weatherRepository.Weather(id));
        }
    }
}
