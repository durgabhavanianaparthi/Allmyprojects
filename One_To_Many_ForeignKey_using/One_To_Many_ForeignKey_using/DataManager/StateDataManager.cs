using One_To_Many_ForeignKey_using.Database;
using One_To_Many_ForeignKey_using.Model;
using One_To_Many_ForeignKey_using.Repository;

namespace One_To_Many_ForeignKey_using.DataManager
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

        public void Update(State _state, State entity)
        {
            _state.StateName = entity.StateName;
            stateAndCityContext.SaveChanges();
        }



    }
}
