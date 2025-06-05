using Microsoft.Extensions.DependencyInjection;
using OrderMicroservice.Application.Interfaces;
using OrderMicroservice.Application.Services;

namespace OrderMicroservice.Application.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IOrderService, OrderService>();
            return services;
        }
    }
}
