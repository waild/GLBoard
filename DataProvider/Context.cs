using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataProvider
{
    public class Context : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
