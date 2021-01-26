using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeMaker.Core.Migrations
{
    public partial class SeedCoffeeMachineAndPods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string query = @"
                   ---COFFEE MACHINE
declare @coffeeMachineProductTypeId_Large INT
declare @coffeeMachineProductTypeId_Small INT
declare @coffeeMachineProductTypeId_ESPRESSO INT

SET @coffeeMachineProductTypeId_Large = (SELECT Id FROM MC.tbProductType WHERE Code ='COFFEE_MACHINE_LARGE')
SET @coffeeMachineProductTypeId_Small = (SELECT Id FROM MC.tbProductType WHERE Code ='COFFEE_MACHINE_SMALL')
SET @coffeeMachineProductTypeId_ESPRESSO = (SELECT Id FROM MC.tbProductType WHERE Code ='ESPRESSO_MACHINE')


declare @coffeeModelId_BASE INT
declare @coffeeModelId_DELUXE INT
declare @coffeeModelId_PREMIUM INT

SET @coffeeModelId_BASE = (SELECT Id FROM MC.[tbCoffeeMachineModel] WHERE Code ='BASE_MODEL')
SET @coffeeModelId_DELUXE = (SELECT Id FROM MC.[tbCoffeeMachineModel] WHERE Code ='DELUXE_MODEL')
SET @coffeeModelId_PREMIUM = (SELECT Id FROM MC.[tbCoffeeMachineModel] WHERE Code ='PREMIUM_MODEL')

--small machine
INSERT INTO MC.tbCoffeeMachine (MachineSKU,ProductTypeId,ModelId,WaterLineCompatible)
                VALUES         ('CM001',@coffeeMachineProductTypeId_Small,@coffeeModelId_BASE,0) 
INSERT INTO MC.tbCoffeeMachine (MachineSKU,ProductTypeId,ModelId,WaterLineCompatible)
                VALUES         ('CM002',@coffeeMachineProductTypeId_Small,@coffeeModelId_PREMIUM,0) 
INSERT INTO MC.tbCoffeeMachine (MachineSKU,ProductTypeId,ModelId,WaterLineCompatible)
                VALUES         ('CM003',@coffeeMachineProductTypeId_Small,@coffeeModelId_DELUXE,1) 
--large machine
INSERT INTO MC.tbCoffeeMachine (MachineSKU,ProductTypeId,ModelId,WaterLineCompatible)
                VALUES         ('CM101',@coffeeMachineProductTypeId_Large,@coffeeModelId_BASE,0) 
INSERT INTO MC.tbCoffeeMachine (MachineSKU,ProductTypeId,ModelId,WaterLineCompatible)
                VALUES         ('CM102',@coffeeMachineProductTypeId_Large,@coffeeModelId_PREMIUM,1) 
INSERT INTO MC.tbCoffeeMachine (MachineSKU,ProductTypeId,ModelId,WaterLineCompatible)
                VALUES         ('CM103',@coffeeMachineProductTypeId_Large,@coffeeModelId_DELUXE,1) 

--espresso machine
INSERT INTO MC.tbCoffeeMachine (MachineSKU,ProductTypeId,ModelId,WaterLineCompatible)
                VALUES         ('EM001',@coffeeMachineProductTypeId_ESPRESSO,@coffeeModelId_BASE,0) 
INSERT INTO MC.tbCoffeeMachine (MachineSKU,ProductTypeId,ModelId,WaterLineCompatible)
                VALUES         ('EM002',@coffeeMachineProductTypeId_ESPRESSO,@coffeeModelId_PREMIUM,0) 
INSERT INTO MC.tbCoffeeMachine (MachineSKU,ProductTypeId,ModelId,WaterLineCompatible)
                VALUES         ('EM003',@coffeeMachineProductTypeId_ESPRESSO,@coffeeModelId_DELUXE,1) 

--END COFFEE MACHINE


--COFFEE PODS
declare @coffeePodProductTypeId_Large INT
declare @coffeePodProductTypeId_Small INT
declare @coffeePodProductTypeId_ESPRESSO INT

SET @coffeePodProductTypeId_Large = (SELECT Id FROM CP.tbProductType WHERE Code ='COFFEE_POD_LARGE')
SET @coffeePodProductTypeId_Small = (SELECT Id FROM CP.tbProductType WHERE Code ='COFFEE_POD_SMALL')
SET @coffeePodProductTypeId_ESPRESSO = (SELECT Id FROM CP.tbProductType WHERE Code ='ESPRESSO_POD')


declare @coffeePodFlavorId_VANILLA INT
declare @coffeePodFlavorId_CARAMEL INT
declare @coffeePodFlavorId_PSL INT
declare @coffeePodFlavorId_MOCHA INT
declare @coffeePodFlavorId_HAZELNUT INT
SET @coffeePodFlavorId_VANILLA = (SELECT Id FROM CP.[tbCoffeeFlavor] WHERE Code ='COFFEE_FLAVOR_VANILLA')
SET @coffeePodFlavorId_CARAMEL = (SELECT Id FROM CP.[tbCoffeeFlavor] WHERE Code ='COFFEE_FLAVOR_CARAMEL')
SET @coffeePodFlavorId_PSL = (SELECT Id FROM CP.[tbCoffeeFlavor] WHERE Code ='COFFEE_FLAVOR_PSL')
SET @coffeePodFlavorId_MOCHA = (SELECT Id FROM CP.[tbCoffeeFlavor] WHERE Code ='COFFEE_FLAVOR_MOCHA')
SET @coffeePodFlavorId_HAZELNUT = (SELECT Id FROM CP.[tbCoffeeFlavor] WHERE Code ='COFFEE_FLAVOR_HAZELNUT')

declare @coffeePodPackSizeId_DOZEN1 INT
declare @coffeePodPackSizeId_DOZEN3 INT
declare @coffeePodPackSizeId_DOZEN5 INT
declare @coffeePodPackSizeId_DOZEN7 INT

SET @coffeePodPackSizeId_DOZEN1 = (SELECT Id FROM CP.tbCoffeePodPackSize WHERE Code ='DOZEN_1')
SET @coffeePodPackSizeId_DOZEN3 = (SELECT Id FROM CP.tbCoffeePodPackSize WHERE Code ='DOZEN_3')
SET @coffeePodPackSizeId_DOZEN5 = (SELECT Id FROM CP.tbCoffeePodPackSize WHERE Code ='DOZEN_5')
SET @coffeePodPackSizeId_DOZEN7 = (SELECT Id FROM CP.tbCoffeePodPackSize WHERE Code ='DOZEN_7')

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP001',@coffeePodProductTypeId_Small,@coffeePodPackSizeId_DOZEN1,@coffeePodFlavorId_VANILLA) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP003',@coffeePodProductTypeId_Small,@coffeePodPackSizeId_DOZEN3,@coffeePodFlavorId_VANILLA) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP011',@coffeePodProductTypeId_Small,@coffeePodPackSizeId_DOZEN1,@coffeePodFlavorId_CARAMEL) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP013',@coffeePodProductTypeId_Small,@coffeePodPackSizeId_DOZEN3,@coffeePodFlavorId_CARAMEL) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP021',@coffeePodProductTypeId_Small,@coffeePodPackSizeId_DOZEN1,@coffeePodFlavorId_PSL) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP023',@coffeePodProductTypeId_Small,@coffeePodPackSizeId_DOZEN3,@coffeePodFlavorId_PSL) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP031',@coffeePodProductTypeId_Small,@coffeePodPackSizeId_DOZEN1,@coffeePodFlavorId_MOCHA) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP033',@coffeePodProductTypeId_Small,@coffeePodPackSizeId_DOZEN3,@coffeePodFlavorId_MOCHA) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP041',@coffeePodProductTypeId_Small,@coffeePodPackSizeId_DOZEN1,@coffeePodFlavorId_HAZELNUT) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP043',@coffeePodProductTypeId_Small,@coffeePodPackSizeId_DOZEN3,@coffeePodFlavorId_HAZELNUT) 

----------------------------------------------------------------------------------

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP101',@coffeePodProductTypeId_Large,@coffeePodPackSizeId_DOZEN1,@coffeePodFlavorId_VANILLA) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP103',@coffeePodProductTypeId_Large,@coffeePodPackSizeId_DOZEN3,@coffeePodFlavorId_VANILLA) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP111',@coffeePodProductTypeId_Large,@coffeePodPackSizeId_DOZEN1,@coffeePodFlavorId_CARAMEL) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP113',@coffeePodProductTypeId_Large,@coffeePodPackSizeId_DOZEN3,@coffeePodFlavorId_CARAMEL) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP121',@coffeePodProductTypeId_Large,@coffeePodPackSizeId_DOZEN1,@coffeePodFlavorId_PSL) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP123',@coffeePodProductTypeId_Large,@coffeePodPackSizeId_DOZEN3,@coffeePodFlavorId_PSL) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP131',@coffeePodProductTypeId_Large,@coffeePodPackSizeId_DOZEN1,@coffeePodFlavorId_MOCHA) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP133',@coffeePodProductTypeId_Large,@coffeePodPackSizeId_DOZEN3,@coffeePodFlavorId_MOCHA) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP141',@coffeePodProductTypeId_Large,@coffeePodPackSizeId_DOZEN1,@coffeePodFlavorId_HAZELNUT) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('CP143',@coffeePodProductTypeId_Large,@coffeePodPackSizeId_DOZEN3,@coffeePodFlavorId_HAZELNUT) 

--------------------------------------------------------------------------------------------------------

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('EP003',@coffeePodProductTypeId_ESPRESSO,@coffeePodPackSizeId_DOZEN3,@coffeePodFlavorId_VANILLA)

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('EP005',@coffeePodProductTypeId_ESPRESSO,@coffeePodPackSizeId_DOZEN5,@coffeePodFlavorId_VANILLA) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('EP007',@coffeePodProductTypeId_ESPRESSO,@coffeePodPackSizeId_DOZEN7,@coffeePodFlavorId_VANILLA) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('EP013',@coffeePodProductTypeId_ESPRESSO,@coffeePodPackSizeId_DOZEN3,@coffeePodFlavorId_CARAMEL) 

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('EP015',@coffeePodProductTypeId_ESPRESSO,@coffeePodPackSizeId_DOZEN5,@coffeePodFlavorId_CARAMEL)

INSERT INTO CP.tbCoffeePod(PodSKU,ProductTypeId,PackSizeId,FlavorId)
VALUES('EP017',@coffeePodProductTypeId_ESPRESSO,@coffeePodPackSizeId_DOZEN7,@coffeePodFlavorId_CARAMEL) 

------------------------------------------------------------------------------------------
                    ";
            migrationBuilder.Sql(query);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
