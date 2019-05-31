using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IGenericRepository<T, N, U> where T : class, new()
                                                 where N : class, new()
                                                 where U : class, new()
    {
        IEnumerable<T> GetCities(string name);
        N Weather(int id);
        IEnumerable<U> Forecfast(int id);
    }
}
