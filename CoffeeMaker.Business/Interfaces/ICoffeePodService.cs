using CoffeeMaker.Domain.Request.CoffeePods;
using CoffeeMaker.Domain.Response.CoffeePods;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Application.Interfaces
{
   public interface ICoffeePodService
    {
        Task<List<CoffeePodResponse>> FilterCoffeePods(CoffeePodFilterRequest filterRequest);
    }
}
