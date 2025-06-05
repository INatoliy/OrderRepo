using Microsoft.Extensions.DependencyInjection;
using OrderMicroservice.Domain.Interfaces;
using OrderMicroservice.Infrastructure.Repositories;

namespace OrderMicroservice.Infrastructure.Extensions
{
    public static class InfracstructureServiceExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();
            return services;
        }
    }
}
