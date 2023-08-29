using Application;
using Domain.Service;
using Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICoffeeBrandService, CoffeeBrandService>();
builder.Services.AddScoped<ICoffeeBrandRepository, InMemoryCoffeeBrandRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

// https://localhost:7263/CoffeeBrand/GetMultiHex