using System.Collections.Generic;

namespace DataContext
{
    // UnitOfWork
    public interface IDataWeatherContext<T, N, U>
    {
        IEnumerable<T> GetListCities(string city);
        N GetWeather(int id);
        IEnumerable<U> GetForecast(int id);
    }
}
