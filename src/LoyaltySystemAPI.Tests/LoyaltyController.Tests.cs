using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoyaltySystemAPI.Controllers;
using LoyaltySystemAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
public class LoyaltyControllerTests
{
   [Fact]
    public async Task Get_ReturnsListOfLoyalties()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<LoyaltyContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var mockContext = new LoyaltyContext(options, "your_db_path"))
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
            Assert.Equal(3, items.Count);
        }
    }

    [Fact]
    public async Task Get_ReturnsLoyaltyById()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<LoyaltyContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
        var mockContext =new LoyaltyContext(options, "your_db_path"); 
        var controller = new LoyaltyController(mockContext);
        var customerId = "1";

        // Act
        var result = await controller.Get(customerId);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var loyalty = Assert.IsType<Loyalty>(okResult.Value);
        Assert.Equal(customerId, loyalty.CustomerID);
    }
}
