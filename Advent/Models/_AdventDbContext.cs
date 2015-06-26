using System.Data.Entity;

namespace Advent.Models
{
    public class AdventDbContext : DbContext
    {
        public AdventDbContext()
            : base("DefaultConnection")
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}