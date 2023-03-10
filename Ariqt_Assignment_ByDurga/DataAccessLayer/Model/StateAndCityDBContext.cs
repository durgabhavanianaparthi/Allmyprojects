using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public  class StateAndCityDBContext : DbContext
    {
        public StateAndCityDBContext(DbContextOptions options)
         : base(options)
        {

        }
        public DbSet<State> StateTable { get; set; }
        public DbSet<City> CityTable { get; set; }
    }
}
