using CoffeeMaker.Core.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IHost MigrateDatabaseToLatestVersion(this IHost host)
        {
            var serviceScopeFactory = (IServiceScopeFactory)host.Services.GetService(typeof(IServiceScopeFactory));

            using (var scope = serviceScopeFactory.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<CoffeeMakerDbContext>();
                dbContext.Database.Migrate();
            }
            return host;
        }
    }
  
}
