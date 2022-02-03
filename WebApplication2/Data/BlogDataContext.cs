using Microsoft.EntityFrameworkCore;
using WebApplication2.Mappings;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder option) 
                => option.UseSqlServer("Server=DESKTOP-AVNGAUK\\SQLEXPRESS;Database=Blog;Integrated Security = SSPI;TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            //modelBuilder.ApplyConfiguration();
            //modelBuilder.ApplyConfiguration();
        }

    }
}
