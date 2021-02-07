using Microsoft.EntityFrameworkCore;
using Repositories.Product;

namespace Repositories.dbContext
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option): base(option)
        { 
        }
        public DbQuery<DBCustomers> Customers { get; set; }
        public DbQuery<DBProvideService> ProvideServices { get; set; }
    }
}
