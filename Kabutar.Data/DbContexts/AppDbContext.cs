using Kabutar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kabutar.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Blog> Blogs { get; set; } = null!;
        
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            #region Blogs
            modelBuilder.Entity<Blog>().HasIndex(x => x.Title).IsUnique();
            #endregion

            #region Users
            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<User>().HasIndex(x => x.PhoneNumber).IsUnique();
            modelBuilder.Entity<User>().HasIndex(x => x.Username).IsUnique();
            #endregion
        }
    }
}
