using System.IO;
using DataLayer.Entities;
namespace DataLayer;

public class BlogDbContext : DbContext {
    
      public BlogDbContext() { }

      public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }

      public DbSet<Blog> Blogs { get; set; } = default!;

      public DbSet<Post> Posts { get; set; } = default!;

      public DbSet<User> Users { get; set; } = default!;

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
            if(!optionsBuilder.IsConfigured)
            {
                  optionsBuilder.UseSqlite("Data Source=:memory:;Version=3;New=True;");
            }

            base.OnConfiguring(optionsBuilder);
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {


            base.OnModelCreating(modelBuilder);
      }

}