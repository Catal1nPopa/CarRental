using CarRentail.Application.Decorator;
using CarRentail.Application.Facade;
using CarRentail.Application.Handlers;
using CarRentail.Application.Requests;
using CarRentail.Application.Services;
using CarRentail.Application.Strategy;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using CarRentail.Infrastructure.Context;
using CarRentail.Infrastructure.Repositories;
using MediatR;
using System.Reflection;

namespace CarRentailAPI.Injections
{
    public static class Application
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetAssembly(typeof(GetRentalHandler));

            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));
            //services.AddValidatorsFromAssembly(assembly));
            //services.AddScoped<IRequestHandler<RentCarRequest, RentalProc>, CreateRentalHandler>();
            //services.AddTransient<IRequestHandler<GetRentailsRequest, List<RentalProc>>, GetRentalHandler>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<ICarRentalFacade, CarRentalFacade>();
            services.AddScoped<IVehicleInspectionService, BasicInspectionService>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddSingleton<ElectricCar>();
            services.AddControllers();
            services.AddDbContext<DataContext>();

            //strategy
            services.AddTransient<StandardPricingStrategy>();
            services.AddTransient<PremiumPricingStrategy>();
            services.AddTransient<RentalService>();
            return services;
        }
    }
}
