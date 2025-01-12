using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using zimmers.core.Entities;

namespace zimmers.data
{
    public class DataContext:DbContext
    {
        public DbSet<Cleaner> Cleaners { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Zimmer> Zimmers { get; set; }

        public DataContext(DbContextOptions<DataContext> option):base(option)
        {     }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}