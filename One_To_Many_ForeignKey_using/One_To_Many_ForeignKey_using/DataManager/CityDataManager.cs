using Microsoft.EntityFrameworkCore;
using One_To_Many_ForeignKey_using.Database;
using One_To_Many_ForeignKey_using.Model;
using One_To_Many_ForeignKey_using.Repository;

namespace One_To_Many_ForeignKey_using.DataManager
{
    public class CityDataManager : IDataRepository<City>
    {
        private readonly StateAndCityContext stateAndCityContext;
        public CityDataManager(StateAndCityContext _StateAndCityContext)
        {
            stateAndCityContext = _StateAndCityContext;
        }
        public void Add(City city)
        {

            var entity = new City
            {
                //CityId = city.CityId,
                CityName = city.CityName,
                StateId = city.StateId,
            };
            stateAndCityContext.Add(entity);
            stateAndCityContext.SaveChanges();
        }

        public void Delete(City city)
        {
            stateAndCityContext.MyCity.Remove(city);
            stateAndCityContext.SaveChanges();
        }

        public City Get(int id)
        {
            var record = stateAndCityContext.MyCity.Find(id);
            return record;
        }

        public IEnumerable<City> GetAll()
        {
            return stateAndCityContext.MyCity.Include("State").ToList();
        }

        public void Update(City dbEntity, City entity)
        {
            dbEntity.CityName = entity.CityName;
            stateAndCityContext.SaveChanges();
        }
    }
}
