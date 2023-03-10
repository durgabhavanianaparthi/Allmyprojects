using Microsoft.EntityFrameworkCore;
using One_many_relationshipWithUsing_ForeignKey.Model;

namespace One_many_relationshipWithUsing_ForeignKey.Database
{
    public class StateAndCityContext:DbContext
    {
        public StateAndCityContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<State> MyState { get; set; }
        public DbSet<City> MyCity { get; set; }
    }
}

