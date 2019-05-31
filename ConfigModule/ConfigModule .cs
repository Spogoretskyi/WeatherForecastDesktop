using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DataLayer;
using Repository;
using DataContext;
using DataLayer.Repositories;

namespace ConfigModule
{
    public class ConfigModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(IDataWeatherContext<CityOW, CurrentWeather, RootObject>)).As(typeof(DataWeatherContext<CityOW, CurrentWeather, RootObject>));
            builder.RegisterType(typeof(BisWeatherOWService)).As(typeof(IEntityService<CityOW, CurrentWeather, RootObject>));
            base.Load(builder);
        }
    }
}
