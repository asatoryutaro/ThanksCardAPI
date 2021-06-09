using Microsoft.EntityFrameworkCore;
using ThanksCardAPI.Models;

namespace ThanksCardAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ThanksCard> ThanksCards{ get; set; }
        public DbSet<ThanksCardAPI.Models.Tag> Tag { get; set; }
        //public object Division { get; internal set; }
        public DbSet<Division> Divisions { get; set; }
    }
}
