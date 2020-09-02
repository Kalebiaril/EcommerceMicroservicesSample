using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.Customers.Db
{
    public class CustomersContext : DbContext
    {
        public DbSet<Customer> Customers{ get; set; }
        public CustomersContext(DbContextOptions options) : base(options)
        {

        }
    }
}
