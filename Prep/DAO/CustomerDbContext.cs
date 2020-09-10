using Microsoft.EntityFrameworkCore;
using Prep.Models;

namespace Prep.DAO
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
        }
        public DbSet<CustomerModel> customers{get;set;}
    }
}