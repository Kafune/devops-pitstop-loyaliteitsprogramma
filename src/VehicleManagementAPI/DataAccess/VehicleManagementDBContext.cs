namespace Pitstop.VehicleManagement.DataAccess;

public class VehicleManagementDBContext : DbContext
{
    public VehicleManagementDBContext(DbContextOptions<VehicleManagementDBContext> options) : base(options)
    {
    }

    public DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Vehicle>().HasKey(m => m.LicenseNumber);
        builder.Entity<Vehicle>().ToTable("Vehicle");
        builder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    LicenseNumber = "123ABC",
                    Brand = "Toyota",
                    Type = "Sedan",
                    OwnerId = "1"
                },
                new Vehicle
                {
                    LicenseNumber = "456DEF",
                    Brand = "Honda",
                    Type = "SUV",
                    OwnerId = "2"
                },
                new Vehicle
                {
                    LicenseNumber = "789GHI",
                    Brand = "Ford",
                    Type = "Truck",
                    OwnerId = "3"
                },
                new Vehicle
                {
                    LicenseNumber = "101JKL",
                    Brand = "Chevrolet",
                    Type = "Convertible",
                    OwnerId = "4"
                },
                 new Vehicle
                {
                    LicenseNumber = "102JKL",
                    Brand = "Chevrolet",
                    Type = "Convertible",
                    OwnerId = "5"
                },
                 new Vehicle
                {
                    LicenseNumber = "166JKL",
                    Brand = "Chevrolet",
                    Type = "Convertible",
                    OwnerId = "6"
                },
                 new Vehicle
                {
                    LicenseNumber = "009JKL",
                    Brand = "Chevrolet",
                    Type = "Convertible",
                    OwnerId = "7"
                }
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