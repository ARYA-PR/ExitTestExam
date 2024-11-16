using Library_management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author);
            modelBuilder.Entity<Category>()
                .HasMany(c=>c.Books)
                .WithOne(b=>b.Category);
           
        }

    }
}
