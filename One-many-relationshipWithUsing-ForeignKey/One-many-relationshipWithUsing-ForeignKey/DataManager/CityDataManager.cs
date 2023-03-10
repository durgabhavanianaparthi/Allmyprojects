using Microsoft.EntityFrameworkCore;
using One_many_relationshipWithUsing_ForeignKey.Database;
using One_many_relationshipWithUsing_ForeignKey.Model;
using One_many_relationshipWithUsing_ForeignKey.Repository;

namespace One_many_relationshipWithUsing_ForeignKey.DataManager
{
    public class CityDataManager: IDataRepository<City>
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
                CityId = city.CityId,
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
            dbEntity.CityName= entity.CityName;
            stateAndCityContext.SaveChanges();
        }
    }
}
