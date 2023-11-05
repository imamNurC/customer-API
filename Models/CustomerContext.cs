using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Models
{
    public class CustomerContext : DbContext
    {
        // DbSet for the Customer model
        public DbSet<CustomerModel> Customers { get; set; }

        // Constructor with DbContextOptions parameter
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }
    }
}
