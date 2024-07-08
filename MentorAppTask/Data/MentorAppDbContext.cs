using MentorAppTask.Models;
using Microsoft.EntityFrameworkCore;

namespace MentorAppTask.Data
{
    public class MentorAppDbContext : DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PricingService> PricingServices{ get; set; }

        public MentorAppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pricing>().Property(p => p.Price).HasColumnType("decimal(18,2)");
        }
    }
}
