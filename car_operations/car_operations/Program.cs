using car_operations.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
builder.Services.AddDbContext<CarsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CarsContext")));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request URL: {context.Request.Path}");
    Console.WriteLine($"Request Method: {context.Request.Method}");
    await next.Invoke();
});


app.MapControllers();

app.Run();
