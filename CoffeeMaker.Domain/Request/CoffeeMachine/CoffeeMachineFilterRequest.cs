using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.Domain.Request.CoffeeMachine
{
   public class CoffeeMachineFilterRequest
    {
        public string ProductType { get; set; }
        public bool? WaterLineCompatible { get; set; }
    }
}
