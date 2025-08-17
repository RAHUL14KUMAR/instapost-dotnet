using instapostBusinesslayer.Interface.CategoryInterface;
using instapostBusinesslayer.Interface.PostInterface;
using instapostBusinesslayer.Interface.UserInterface;
using instapostBusinesslayer.Repository;
using instapostBusinesslayer.Service.Implementation;
using instapostBusinesslayer.Service.Interface;
using instapostDataLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddOpenApi();
builder.Services.AddDbContext<ApplicationDbContext>(Options => Options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<CategoryIRepository, CategoryRepository>();
builder.Services.AddScoped<CategorySInterface, CategoryService>();

builder.Services.AddScoped<UserIRepository, UserRepository>();
builder.Services.AddScoped<UserSInterface, UserService>();

builder.Services.AddScoped<PostIRepository, PostRepository>();
builder.Services.AddScoped<PostSInterface, PostService>();

builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
// through this code we can test the api through thunder c;ient or postman
app.MapControllers();
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
