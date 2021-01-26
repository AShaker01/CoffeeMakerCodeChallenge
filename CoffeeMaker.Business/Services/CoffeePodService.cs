using CoffeeMaker.Application.Interfaces;
using CoffeeMaker.Core.DomainModels;
using CoffeeMaker.Core.Persistence;
using CoffeeMaker.Domain.Request.CoffeePods;
using CoffeeMaker.Domain.Response.CoffeePods;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeeMaker.Application.Services
{
    public class CoffeePodService : ICoffeePodService
    {
        private readonly CoffeeMakerDbContext _dbContext;
        public CoffeePodService(CoffeeMakerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<CoffeePodResponse>> FilterCoffeePods(CoffeePodFilterRequest filterRequest)
        {
            var coffeePods =  await _dbContext.CoffeePods
                .Include(cp => cp.Flavor)
                .Include(cp => cp.PackSize)
                .Include(cp => cp.ProductType)
                .Where(cp => 
                          (string.IsNullOrEmpty(filterRequest.Flavor) || cp.Flavor.Code == filterRequest.Flavor)
                       && (string.IsNullOrEmpty(filterRequest.ProductType) || cp.ProductType.Code == filterRequest.ProductType) 
                       && (string.IsNullOrEmpty(filterRequest.PackSize) || cp.PackSize.Code == filterRequest.PackSize)
                       ).ToListAsync();
            return coffeePods.Select(pod => new CoffeePodResponse()
            {
                Id = pod.Id,
                PodSKU = pod.PodSKU,
                Flavor = pod.Flavor.Name,
                PackSize = pod.PackSize.Name,
                ProductType = pod.ProductType.Name
            }).ToList();
        }
    }
  
}
