using CarRentail.Application.Decorator;
using CarRentail.Application.Facade;
using CarRentail.Application.Strategy;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using CarRentail.Infrastructure.Context;
using CarRentail.Infrastructure.Repositories;
using CarRentailAPI.Injections;

var builder = WebApplication.CreateBuilder(args);
var webHostBuilder = builder.WebHost;
// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApplication();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(option => option.AddPolicy(name: "CarRentailAPI",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    }));

webHostBuilder.ConfigureServices(services =>
{
    services.AddScoped<IVehicleRepository, VehicleRepository>();
    services.AddScoped<ICarRentalFacade, CarRentalFacade>();
    services.AddScoped<IVehicleInspectionService, BasicInspectionService>();
    services.AddSingleton<ElectricCar>();
    services.AddControllers();
    services.AddDbContext<DataContext>();

    //iterator
    services.AddSingleton<VehicleList>(new VehicleList(
        new List<HybridCar>(), 
        new List<ElectricCar>(), 
        new List<CombustionCar>(), 
        new List<ElectricMotorcycle>(), 
        new List<CombustionMotorcycle>() 
    ));


    //strategy
    services.AddTransient<StandardPricingStrategy>();
    services.AddTransient<PremiumPricingStrategy>();
    services.AddTransient<RentalService>();

});
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarRentail API v1"));
}

app.UseHttpsRedirection();

//app.UseRouting();///

app.UseCors("CarRentailAPI");

app.UseAuthorization();

app.MapControllers();

app.Run();

////
app.UseEndpoints(endpoints =>/////
{
    endpoints.MapControllers();
});
