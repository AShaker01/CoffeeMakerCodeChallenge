using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.Domain.Response.CoffeeMachine
{
   public class CoffeeMachineResponse
    {
        public int Id { get; set; }
        public string MachineSKU { get; set; }
        public string ProductType { get; set; }
        public string MachineModel { get; set; }
        public bool WaterLineCompatible { get; set; }
    }
}
