using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace LoyaltySystemAPI.Models
{
    public class LoyaltyContext : DbContext
    {
        public DbSet<Loyalty> Loyalties{ get; set; }
        public string DbPath { get; }

        public LoyaltyContext(DbContextOptions<LoyaltyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Loyalty>()
                .Property(m => m.CustomerID)
                .ValueGeneratedNever();

            builder.Entity<Loyalty>().HasKey(m => m.CustomerID);
            builder.Entity<Loyalty>().ToTable("Loyalty");

            base.OnModelCreating(builder);
        }

        public void MigrateDB()
        {
            Policy
                .Handle<Exception>()
                .WaitAndRetry(10, r => TimeSpan.FromSeconds(10))
                .Execute(() => Database.Migrate());
        }
    }
}
