using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CoffeeMaker.Core.Persistence;
using CoffeeMaker.Constants.Enums;
using CoffeeMaker.Application.Interfaces;
using CoffeeMaker.Application.Services;

namespace CoffeeMaker.Infrastructure.Extensions
{
    public static class ConfigureServiceContainer
    {
        public static void AddDbContext(this IServiceCollection serviceCollection,
             IConfiguration configuration)
        {
            serviceCollection.AddDbContext<CoffeeMakerDbContext>(options =>
                   options.UseSqlServer(configuration.GetConnectionString(ConfigParams.ConnectionStringKey)
                , b => b.MigrationsAssembly(typeof(CoffeeMakerDbContext).Assembly.FullName)).EnableSensitiveDataLogging(true));
        }
        public static void AddScopedServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<CoffeeMakerDbContext>();
            serviceCollection.AddScoped<ICoffeePodService, CoffeePodService>();
            serviceCollection.AddScoped<ICoffeeMachineService, CoffeeMachineService>();
        }
        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
          
        }
    }
}
