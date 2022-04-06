using ChoparPizza.Data.IRepositories;
using ChoparPizza.Data.Repositories;
using ChoparPizza.Service.Interfaces;
using ChoparPizza.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ChoparPizza.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPizzaService, PizzaService>();
        }
    }
}
