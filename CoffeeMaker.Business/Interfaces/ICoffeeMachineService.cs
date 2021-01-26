using CoffeeMaker.Domain.Request.CoffeeMachine;
using CoffeeMaker.Domain.Response.CoffeeMachine;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Application.Interfaces
{
   public interface ICoffeeMachineService
    {
        Task<List<CoffeeMachineResponse>> FilterCoffeeMachines(CoffeeMachineFilterRequest filterRequest);
    }
}
