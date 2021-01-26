using Microsoft.EntityFrameworkCore;
using CoffeeMaker.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.Core.Persistence
{
    public class DataSeedingManager
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            SeedCoffeeMachinesProductTypes(modelBuilder);
            SeedCoffeeMachinesModels(modelBuilder);
            SeedCoffeePodsProductTypes(modelBuilder);
            SeedCoffeePodsFlavor(modelBuilder);
            SeedCoffeePodsPackSize(modelBuilder);
        }

        private static void SeedCoffeeMachinesProductTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeeMachineProductTypeEntity>().HasData(
               new CoffeeMachineProductTypeEntity()
               {
                   Id = 1,
                   Name = "COFFEE MACHINE LARGE",
                   Code = "COFFEE_MACHINE_LARGE"
               },
               new CoffeeMachineProductTypeEntity()
               {
                   Id = 2,
                   Name = "COFFEE MACHINE SMALL",
                   Code = "COFFEE_MACHINE_SMALL"
               },
                new CoffeeMachineProductTypeEntity()
                {
                    Id = 3,
                    Name = "ESPRESSO MACHINE",
                    Code = "ESPRESSO_MACHINE"
                }
            );
        }
        private static void SeedCoffeeMachinesModels(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeeMachineModelEntity>().HasData(
            new CoffeeMachineModelEntity()
            {
                Id = 1,
                Name = "BASE",
                Code = "BASE_MODEL"
            },
            new CoffeeMachineModelEntity()
            {
                Id = 2,
                Name = "DELUXE",
                Code = "DELUXE_MODEL"
            },
             new CoffeeMachineModelEntity()
             {
                 Id = 3,
                 Name = "PREMIUM",
                 Code = "PREMIUM_MODEL"
             });
        }
        private static void SeedCoffeePodsProductTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeePodProductTypeEntity>().HasData(
              new CoffeePodProductTypeEntity()
              {
                  Id = 1,
                  Name = "COFFEE POD LARGE",
                  Code = "COFFEE_POD_LARGE"
              },
              new CoffeePodProductTypeEntity()
              {
                  Id = 2,
                  Name = "COFFEE POD SMALL",
                  Code = "COFFEE_POD_SMALL"
              },
              new CoffeePodProductTypeEntity()
              {
                  Id = 3,
                  Name = "ESPRESSO POD",
                  Code = "ESPRESSO_POD"
              }
           );
        }
        private static void SeedCoffeePodsFlavor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeePodFlavorEntity>().HasData(
            new CoffeePodFlavorEntity()
            {
                Id = 1,
                Name = "COFFEE FLAVOR VANILLA",
                Code = "COFFEE_FLAVOR_VANILLA"
            },
            new CoffeePodFlavorEntity()
            {
                Id = 2,
                Name = "COFFEE FLAVOR_CARAMEL",
                Code = "COFFEE_FLAVOR_CARAMEL"
            },
             new CoffeePodFlavorEntity()
             {
                 Id = 3,
                 Name = "COFFEE FLAVOR PSL",
                 Code = "COFFEE_FLAVOR_PSL"
             },
               new CoffeePodFlavorEntity()
               {
                   Id = 4,
                   Name = "COFFEE_FLAVOR_MOCHA",
                   Code = "COFFEE_FLAVOR_MOCHA"
               },
              new CoffeePodFlavorEntity()
              {
                  Id = 5,
                  Name = "COFFEE FLAVOR HAZELNUT",
                  Code = "COFFEE_FLAVOR_HAZELNUT"
              }
         );
        }
        private static void SeedCoffeePodsPackSize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeePodPackSizeEntity>().HasData(
               new CoffeePodPackSizeEntity()
               {
               Id = 1,
               Name = "1 dozen (12)",
               Code = "DOZEN_1"
               },
               new CoffeePodPackSizeEntity()
               {
                 Id = 2,
                 Name = "3 dozen (36)",
                 Code = "DOZEN_3"
               },
               new CoffeePodPackSizeEntity()
               {
                   Id = 3,
                   Name = "5 dozen (60)",
                   Code = "DOZEN_5"
               },
               new CoffeePodPackSizeEntity()
               {
                     Id = 4,
                     Name = "7 dozen (84)",
                     Code = "DOZEN_7"
               }
           );
        }
    }
}
