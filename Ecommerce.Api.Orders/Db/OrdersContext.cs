using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.Orders.Db
{
    public class OrdersContext : DbContext
    {
        public DbSet<Order> Orders{ get; set; }
        public OrdersContext(DbContextOptions options) : base(options)
        {

        }
    }
}
