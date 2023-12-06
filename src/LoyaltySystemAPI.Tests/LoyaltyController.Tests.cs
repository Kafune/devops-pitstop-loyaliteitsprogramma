//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using LoyaltySystemAPI.Controllers;
//using LoyaltySystemAPI.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Moq;
//using Xunit;

//public class LoyaltyControllerTests
//{
//    [Fact]
//    public void Get_ReturnsListOfLoyalties()
//    {
//        // Arrange
//        var mockContext = new Mock<LoyaltyContext>();
//        var loyaltyData = new List<Loyalty>
//        {
//            // voeg dummygegevens toe zoals vereist
//        }.AsQueryable();

//        var mockDbSet = new Mock<DbSet<Loyalty>>();
//        mockDbSet.As<IQueryable<Loyalty>>().Setup(m => m.Provider).Returns(loyaltyData.Provider);
//        mockDbSet.As<IQueryable<Loyalty>>().Setup(m => m.Expression).Returns(loyaltyData.Expression);
//        mockDbSet.As<IQueryable<Loyalty>>().Setup(m => m.ElementType).Returns(loyaltyData.ElementType);
//        mockDbSet.As<IQueryable<Loyalty>>().Setup(m => m.GetEnumerator()).Returns(loyaltyData.GetEnumerator());

//        mockContext.Setup(c => c.Loyalties).Returns(mockDbSet.Object);

//        var controller = new LoyaltyController(mockContext.Object);

//        // Act
//        var result = controller.Get().Result;

//        // Assert
//        var okResult = Assert.IsType<OkObjectResult>(result);
//        var items = Assert.IsType<List<Loyalty>>(okResult.Value);
//        Assert.Equal(loyaltyData.Count(), items.Count);
//    }
//}
