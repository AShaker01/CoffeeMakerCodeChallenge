using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.Domain.Response.CoffeePods
{
   public class CoffeePodResponse
    {
        public int Id { get; set; }
        public string PodSKU { get; set; }
        public string ProductType { get; set; }
        public string PackSize { get; set; }
        public string Flavor { get; set; }
    }
}
