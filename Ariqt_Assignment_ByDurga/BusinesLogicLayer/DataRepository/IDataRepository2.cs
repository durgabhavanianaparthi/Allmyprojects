using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogicLayer.DataRepository
{
    public  interface IDataRepository2<TEntity>
    {
       Task<IEnumerable<City>> GetAllAsync();
    }
}
