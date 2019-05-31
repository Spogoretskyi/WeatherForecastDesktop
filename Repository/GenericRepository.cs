using System.Collections.Generic;
using DataContext;

namespace Repository
{
    public abstract class GenericRepository<T, N, U> : IGenericRepository<T, N, U> where T : class, new()
                                                                                   where N : class, new()
                                                                                   where U : class, new()

    {
        DataWeatherContext<T, N, U> dataWeatherContext;
        public GenericRepository(DataWeatherContext<T, N, U> context)
        {
            dataWeatherContext = context;
        }
        public IEnumerable<T> GetCities(string name)
        {
            return dataWeatherContext.GetListCities(name);
        }

        public N Weather(int id)
        {
            return dataWeatherContext.GetWeather(id);
        }
        public IEnumerable<U> Forecfast(int id)
        {
            return dataWeatherContext.GetForecast(id);
        }
    }
}
