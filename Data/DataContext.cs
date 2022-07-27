using EntityRelationship.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityRelationship.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Charecter> Charecters { get; set; }
    }
}
