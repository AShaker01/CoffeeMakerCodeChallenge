using CoffeeMaker.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeMaker.Core.DomainModels
{
    [Table("tbCoffeePod", Schema = Schemas.COFFEE_PODS)]
    public class CoffeePodEntity : BaseEntity
    {
        public string PodSKU { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("Flavor")]
        public int FlavorId { get; set; }
        [ForeignKey("PackSize")]
        public int PackSizeId { get; set; }
        public CoffeePodProductTypeEntity ProductType { get; set; }
        public CoffeePodFlavorEntity Flavor { get; set; }
        public CoffeePodPackSizeEntity PackSize { get; set; }
    }
}
