using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace LoyalitySystemAPI.Models
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

            builder.Entity<Loyalty>().HasData(
                new Loyalty { CustomerID = "1", Points = "100", Category = "zilver" },
                new Loyalty { CustomerID = "2", Points = "200", Category = "zilver" },
                new Loyalty { CustomerID = "3", Points = "2000", Category ="platina" },
                new Loyalty { CustomerID = "4", Points = "600", Category = "goud" },
                new Loyalty { CustomerID = "5", Points = "800", Category = "goud" },
                new Loyalty { CustomerID = "6", Points = "750", Category = "goud" },
                new Loyalty { CustomerID = "7", Points = "925", Category = "goud" },
                new Loyalty { CustomerID = "8", Points = "550", Category = "goud" }
            );

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
