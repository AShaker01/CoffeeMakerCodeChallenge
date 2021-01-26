using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.Domain.Request.CoffeePods
{
    public class CoffeePodFilterRequest
    {
        public string ProductType { get; set; }
        public string Flavor { get; set; }
        public string PackSize{ get; set; }
    }
}
