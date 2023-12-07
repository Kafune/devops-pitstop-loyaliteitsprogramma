using LoyaltySystemAPI.Controllers;
using LoyaltySystemAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pitstop.WebApp.Models;

public class LoyaltyControllerTests
{
    [Fact]
    public async Task Get_ReturnsListOfLoyalties()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<LoyaltyContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var mockContext = new LoyaltyContext(options))
        {
            mockContext.Loyalties.AddRange(new List<Loyalty>
            {
                new Loyalty { CustomerID = "1", Points = "100", Category = "Zilver" },
                new Loyalty { CustomerID = "2", Points = "200", Category = "Goud" },
                new Loyalty { CustomerID = "3", Points = "300", Category = "Platina" },
            });

            mockContext.SaveChanges();

            var controller = new LoyaltyController(mockContext);

            // Act
            var result = await controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var items = Assert.IsType<List<Loyalty>>(okResult.Value);
            Assert.Equal(4, items.Count); // Adjust to the expected count
        }
    }

    [Fact]
    public async Task Get_ReturnsLoyaltyById()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<LoyaltyContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
        using (var mockContext = new LoyaltyContext(options))
        {
            mockContext.Loyalties.Add(new Loyalty { CustomerID = "6", Points = "100", Category = "Zilver" });
            mockContext.SaveChanges();

            var controller = new LoyaltyController(mockContext);
            var customerId = "6";

            // Act
            var result = await controller.Get(customerId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var loyalty = Assert.IsType<Loyalty>(okResult.Value);
            Assert.Equal(customerId, loyalty.CustomerID);
        }
    }

    [Fact]
    public async Task AddPoints_ReturnsOkResult()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<LoyaltyContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var mockContext = new LoyaltyContext(options))
        {
            mockContext.Loyalties.Add(new Loyalty { CustomerID = "5", Points = "100", Category = "Zilver" });
            mockContext.SaveChanges();

            var controller = new LoyaltyController(mockContext);
            var customerId = "5";
            var pointsToAdd = 50;
            var loyaltyrequest = new AddLoyaltyPointsRequest
            {
                CustomerId = customerId,
                LoyaltyPoints = pointsToAdd
            };

            // Act
            var result = await controller.AddPoints(loyaltyrequest);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var message = Assert.IsType<string>(okResult.Value);
            Assert.Contains(customerId, message);

            // Check data consistency
            var updatedLoyalty = mockContext.Loyalties.Find(customerId);
            Assert.Equal("150", updatedLoyalty.Points); // Adjust to the expected value
        }
    }

    [Fact]
    public async Task AddCustomer_ReturnsOkResult()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<LoyaltyContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var mockContext = new LoyaltyContext(options))
        {
            var controller = new LoyaltyController(mockContext);
            var customerDto = new CustomerDto { CustomerID = "4" };

            // Act
            var result = await controller.AddCustomer(customerDto);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var message = Assert.IsType<string>(okResult.Value);
            Assert.Contains(customerDto.CustomerID, message);

            // Check data consistency
            var addedCustomer = mockContext.Loyalties.Find(customerDto.CustomerID);
            Assert.NotNull(addedCustomer);
        }
    }
}