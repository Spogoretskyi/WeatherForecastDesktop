using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContext;
using Repository;

namespace DataLayer.Repositories
{
    public class OwRepository : GenericRepository<CityOW, CurrentWeather, RootObject>
    {
        public OwRepository(DataWeatherContext<CityOW, CurrentWeather, RootObject> context) : base(context)
        { }

    }
}
