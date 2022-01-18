using Apricot.Domain.Aggregate.Blog;
using Apricot.Domain.Aggregate.User;
using Apricot.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Apricot.Infrastructure
{
    public class ApricotDbContext : DbContext
    {
        public ApricotDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}