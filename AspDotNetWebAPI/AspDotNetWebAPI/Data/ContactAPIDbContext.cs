using AspDotNetWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetWebAPI.Data
{
    public class ContactAPIDbContext:DbContext
    {
        public ContactAPIDbContext(DbContextOptions options): base(options)
        {
        }
        public DbSet< Contact> Contacts { get; set; }

    }
}
