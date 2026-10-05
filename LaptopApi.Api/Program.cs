using LaptopApi.Application;
using LaptopApi.Domain;
using LaptopApi.Infrastructure;
using Microsoft.FeatureManagement;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Feature Management
builder.Services.AddFeatureManagement();

// Register Clean Architecture Dependencies
builder.Services.AddScoped<ILaptopRepository, InMemoryLaptopRepository>();
builder.Services.AddScoped<ILaptopService, LaptopService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();