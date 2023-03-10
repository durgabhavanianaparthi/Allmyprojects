using Microsoft.EntityFrameworkCore;
using One_many_relationshipWithUsing_ForeignKey.Database;
using One_many_relationshipWithUsing_ForeignKey.Model;
using One_many_relationshipWithUsing_ForeignKey.Repository;

namespace One_many_relationshipWithUsing_ForeignKey.DataManager
{
    public class StateDataManager : IDataRepository<State>
    {
        private readonly StateAndCityContext stateAndCityContext;
        public StateDataManager(StateAndCityContext _StateAndCityContext)
        {
            stateAndCityContext = _StateAndCityContext;
        }

        public void Add(State entity)
        {
           
            stateAndCityContext.MyState.Add(entity);
            stateAndCityContext.SaveChanges();
        }

        public void Delete(State _state)
        {
            stateAndCityContext.MyState.Remove(_state);
            stateAndCityContext.SaveChanges();
        }

        public State Get(int id)
        {
            State result = stateAndCityContext.MyState.Find(id);
            return result;
        }

        public IEnumerable<State> GetAll()
        {
            return stateAndCityContext.MyState.ToList();
        }

        public void Update(State dbEntity, State entity)
        {
            dbEntity.StateName = entity.StateName;
            stateAndCityContext.SaveChanges();
        }
    }
}
