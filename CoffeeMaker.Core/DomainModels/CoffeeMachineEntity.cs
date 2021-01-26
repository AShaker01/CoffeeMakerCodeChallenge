using CoffeeMaker.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeMaker.Core.DomainModels
{
    [Table("tbCoffeeMachine", Schema = Schemas.COFFEE_MACHINE)]
    public class CoffeeMachineEntity : BaseEntity
    {
        public string MachineSKU { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("Model")]
        public int ModelId { get; set; }
        public bool WaterLineCompatible { get; set; }
        public CoffeeMachineModelEntity Model { get; set; }
        public CoffeeMachineProductTypeEntity ProductType { get; set; }
    }
}
