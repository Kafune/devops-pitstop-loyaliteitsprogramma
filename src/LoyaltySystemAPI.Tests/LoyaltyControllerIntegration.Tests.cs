using System.Net;
using System.Text;
using LoyaltySystemAPI.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Pitstop.WebApp.Models;

public class LoyaltyControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public LoyaltyControllerIntegrationTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient(new WebApplicationFactoryClientOptions
        {
            BaseAddress = new Uri("https://localhost:5300")
        });

        Task.Run(async () =>
        {
            var customerDto = new CustomerDto
            {
                CustomerID = "1234",
                
            };
            var jsonRequest = JsonConvert.SerializeObject(customerDto);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            await _client.PostAsync("/api/Loyalty/AddCustomer", content);
        }).Wait();


    }

    [Fact]
    public async Task Get_ReturnsSuccessStatusCode()
    {
        // Arrange & Act
        var response = await _client.GetAsync("/api/Loyalty");

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task GetById_ReturnsSuccessStatusCode()
    {
        //Arrange & Act
        var response = await _client.GetAsync("/api/Loyalty/GetById/1234");

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task AddPoints_ReturnsSuccessStatusCode()
    {
        // Arrange
        var request = new AddLoyaltyPointsRequest
        {
            CustomerId = "1234",
            LoyaltyPoints = 10
        };

        var jsonRequest = JsonConvert.SerializeObject(request);
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        // Act
        var response = await _client.PostAsync("/api/Loyalty/AddPoints", content);

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task AddCustomer_ReturnsSuccessStatusCode()
    {
        // Arrange
        var customerDto = new CustomerDto
        {
            CustomerID = "5678",
        };

        var jsonRequest = JsonConvert.SerializeObject(customerDto);
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        // Act
        var response = await _client.PostAsync("/api/Loyalty/AddCustomer", content);

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}
