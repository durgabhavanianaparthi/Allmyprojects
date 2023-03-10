using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UnitTesting_Using_WebApi.Model;

namespace UnitTesting_Using_WebApi.Data
{
    public class DbContextClass:DbContext
    {
        //protected readonly IConfiguration Configuration;

        //public DbContextClass(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}
        ////protected override void OnConfiguring(DbContextOptionsBuilder options)
        ////{
        ////    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        ////}
        //public DbSet<Product> Products { get; set; }
        public DbContextClass(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
