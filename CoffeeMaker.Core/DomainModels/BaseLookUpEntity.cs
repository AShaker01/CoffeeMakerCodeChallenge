using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.Core.DomainModels
{
    public class BaseLookUpEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
