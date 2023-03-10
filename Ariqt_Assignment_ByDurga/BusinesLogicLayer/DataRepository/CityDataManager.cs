using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogicLayer.DataRepository
{
    public class CityDataManager : IDataRepository1<City>, IDataRepository2<City>
    {
        private readonly StateAndCityDBContext stateAndCityDBContext;
        public CityDataManager(StateAndCityDBContext _StateAndCityDBContext)
        {
            stateAndCityDBContext = _StateAndCityDBContext;
        }

        public void  Add(City city)
        {
            var entity = new City
            {
                //CityId = city.CityId,
                CityName= city.CityName,
                TotalCityPopulation = city.TotalCityPopulation,
                LiteracyRate= city.LiteracyRate,
                 StateId = city.StateId
            };
            stateAndCityDBContext.Add(entity);
            stateAndCityDBContext.SaveChanges();

           // return entity;
            // City newCity = Add(city);
            //Console.WriteLine($"Recently added city: {newCity.CityName}, population {newCity.TotalCityPopulation}, literacy rate {newCity.LiteracyRate}");

        }

        public void Delete(City city)
        {
            stateAndCityDBContext.CityTable.Remove(city);
            stateAndCityDBContext.SaveChanges();
        }

        public City Get(int id)
        {
            var record = stateAndCityDBContext.CityTable.Find(id);
            return record;
            //var record = stateAndCityDBContext.CityTable.Include(x => x.State).FirstOrDefault(y => y.CityId == id);
            //return record;

        }

        public IEnumerable<City> GetAll()
        {
            return stateAndCityDBContext.CityTable.ToList();
        }



        public void Update(City _city, City city)
        {
            _city.CityName = city.CityName;

            _city.TotalCityPopulation = city.TotalCityPopulation;

            _city.LiteracyRate = city.LiteracyRate;

            stateAndCityDBContext.SaveChanges();
        }



        public async Task<IEnumerable<City>> GetAllAsync()
        {
            return await stateAndCityDBContext.CityTable.Include(y => y.State).ToListAsync();
        }


    }
}
