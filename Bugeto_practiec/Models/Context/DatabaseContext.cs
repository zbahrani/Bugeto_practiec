using Bugeto_practiec.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Bugeto_practiec.Models.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

    

        public DbSet<Customer> Customers { get; set; }

        
    }
}
