using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using zimmers.core.Entities;

namespace zimmers.data
{
    public class DataContext:DbContext
    {
        public DbSet<Cleaner> cleaners { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Owner> owners { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Zimmer> zimmer { get; set; }

        public DataContext(DbContextOptions<DataContext> option):base(option)
        {     }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}