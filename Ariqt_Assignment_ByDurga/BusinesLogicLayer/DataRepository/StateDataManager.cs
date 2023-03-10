using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogicLayer.DataRepository
{
    public class StateDataManager : IDataRepository1<State>
    {
        private readonly StateAndCityDBContext stateAndCityDBContext;
        public StateDataManager(StateAndCityDBContext _StateAndCityDBContext)
        {
            stateAndCityDBContext = _StateAndCityDBContext;
        }
        public void Add(State state)
        {
            var states = new State
            {
               //CityId = city.CityId,
                StateName = state.StateName,
                State_CM=state.State_CM,
                TotalStatePopulation = state.TotalStatePopulation,
              TollFreeNumber=state.TollFreeNumber,



    };
            stateAndCityDBContext.StateTable.Add(states);
            stateAndCityDBContext.SaveChanges();
        }

        public void Delete(State state)
        {
            stateAndCityDBContext.StateTable.Remove(state); 
            stateAndCityDBContext.SaveChanges();

        }

        public State Get(int id)
        {
            State result = stateAndCityDBContext.StateTable.Find(id);
            return result;
        }

        public IEnumerable<State> GetAll()
        {
            return stateAndCityDBContext.StateTable.ToList();
        }

        public void Update(State _state, State state)
        {
            _state.StateName = state.StateName;
            _state.State_CM = state.State_CM;
            _state.TotalStatePopulation = state.TotalStatePopulation;
            _state.TollFreeNumber = state.TollFreeNumber;




            stateAndCityDBContext.SaveChanges();
        }
    }
}
