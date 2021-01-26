using CoffeeMaker.Application.Interfaces;
using CoffeeMaker.Core.Persistence;
using CoffeeMaker.Domain.Request.CoffeeMachine;
using CoffeeMaker.Domain.Response.CoffeeMachine;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Application.Services
{
    public class CoffeeMachineService : ICoffeeMachineService
    {
        private readonly CoffeeMakerDbContext _dbContext;
        public CoffeeMachineService(CoffeeMakerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<CoffeeMachineResponse>> FilterCoffeeMachines(CoffeeMachineFilterRequest filterRequest)
        {
            var coffeeMachines = await _dbContext.CoffeeMachines
              .Include(cm => cm.ProductType)
              .Include(cm => cm.Model)
              .Where(cm =>
                        (string.IsNullOrEmpty(filterRequest.ProductType) || cm.ProductType.Code == filterRequest.ProductType)
                     && (!filterRequest.WaterLineCompatible.HasValue || cm.WaterLineCompatible == filterRequest.WaterLineCompatible.Value)
                     ).ToListAsync();
            return coffeeMachines.Select(machine => new CoffeeMachineResponse()
            {
                Id = machine.Id,
                MachineSKU = machine.MachineSKU,
                MachineModel = machine.Model.Name,
                ProductType = machine.ProductType.Name,
                WaterLineCompatible = machine.WaterLineCompatible
            }).ToList();
        }
    }
}
