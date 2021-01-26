using CoffeeMaker.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeMaker.Core.DomainModels
{
    [Table("tbCoffeeFlavor", Schema = Schemas.COFFEE_PODS)]
    public class CoffeePodFlavorEntity : BaseLookUpEntity
    {
    }
}
