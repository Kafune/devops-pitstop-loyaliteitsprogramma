var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var sqlConnectionString = builder.Configuration.GetConnectionString("LoyaltyServiceCN");
builder.Services.AddDbContext<LoyaltyContext>(options => options.UseSqlServer(sqlConnectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Register the Swagger generator, defining one or more Swagger documents
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "LoyaltyProgram API", Version = "v1" });
});


var app = builder.Build();


app.UseSwagger();

// Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "LoyaltyProgram API - v1");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
