namespace Pitstop.CustomerManagementAPI.DataAccess;

public class CustomerManagementDBContext : DbContext
{
    public CustomerManagementDBContext(DbContextOptions<CustomerManagementDBContext> options) : base(options)
    {

    }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Customer>().HasKey(m => m.CustomerId);
        builder.Entity<Customer>().ToTable("Customer");
        builder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = "1",
                    Name = "John Doe",
                    Address = "123 Main Street",
                    PostalCode = "12345",
                    City = "Sample City",
                    TelephoneNumber = "123-456-7890",
                    EmailAddress = "john.doe@example.com"
                },
                new Customer
                {
                    CustomerId = "2",
                    Name = "Jane Smith",
                    Address = "456 Elm Street",
                    PostalCode = "67890",
                    City = "Another City",
                    TelephoneNumber = "987-654-3210",
                    EmailAddress = "jane.smith@example.com"
                },
                new Customer
                {
                    CustomerId = "3",
                    Name = "Bob Johnson",
                    Address = "789 Oak Street",
                    PostalCode = "54321",
                    City = "Yet Another City",
                    TelephoneNumber = "111-222-3333",
                    EmailAddress = "bob.johnson@example.com"
                },
                new Customer
                {
                    CustomerId = "4",
                    Name = "Alice Brown",
                    Address = "101 Pine Street",
                    PostalCode = "13579",
                    City = "Final City",
                    TelephoneNumber = "999-888-7777",
                    EmailAddress = "alice.brown@example.com"
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