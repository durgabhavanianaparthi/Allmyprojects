using Many_to_Many_ForeignKeyUsing.Model;
using Microsoft.EntityFrameworkCore;

namespace Many_to_Many_ForeignKeyUsing.Database
{
    public class API_DBContext : DbContext
    {
        public API_DBContext(DbContextOptions<API_DBContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerProduct> CustomersProducts { get; set; }

    }
}
