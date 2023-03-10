using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using One_To_Many_ForeignKey_using.Model;
using System.Collections.Generic;

namespace One_To_Many_ForeignKey_using.Database
{
    public class StateAndCityContext : DbContext
    {
        public StateAndCityContext(DbContextOptions options)
          : base(options)
        {
            var conn = (SqlConnection)this.Database.GetDbConnection();
            conn.AccessToken = (new AzureServiceTokenProvider()).GetAccessTokenAsync("https://database.windows.net/").Result;
        }
        public DbSet<State> MyState { get; set; }
        public DbSet<City> MyCity { get; set; }
    }
}
