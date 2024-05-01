using CarRentail.Application.Handlers;
using CarRentail.Application.Requests;
using CarRentail.Domain.Entities;
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
            
            return services;
        }
    }
}
