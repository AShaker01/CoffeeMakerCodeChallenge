using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeMaker.Core.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "MC");

            migrationBuilder.EnsureSchema(
                name: "CP");

            migrationBuilder.CreateTable(
                name: "tbCoffeeFlavor",
                schema: "CP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCoffeeFlavor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbCoffeePodPackSize",
                schema: "CP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCoffeePodPackSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbProductType",
                schema: "CP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbCoffeeMachineModel",
                schema: "MC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCoffeeMachineModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbProductType",
                schema: "MC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbCoffeePod",
                schema: "CP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PodSKU = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    FlavorId = table.Column<int>(nullable: false),
                    PackSizeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCoffeePod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbCoffeePod_tbCoffeeFlavor_FlavorId",
                        column: x => x.FlavorId,
                        principalSchema: "CP",
                        principalTable: "tbCoffeeFlavor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbCoffeePod_tbCoffeePodPackSize_PackSizeId",
                        column: x => x.PackSizeId,
                        principalSchema: "CP",
                        principalTable: "tbCoffeePodPackSize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbCoffeePod_tbProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalSchema: "CP",
                        principalTable: "tbProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbCoffeeMachine",
                schema: "MC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineSKU = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ModelId = table.Column<int>(nullable: false),
                    WaterLineCompatible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCoffeeMachine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbCoffeeMachine_tbCoffeeMachineModel_ModelId",
                        column: x => x.ModelId,
                        principalSchema: "MC",
                        principalTable: "tbCoffeeMachineModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbCoffeeMachine_tbProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalSchema: "MC",
                        principalTable: "tbProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "CP",
                table: "tbCoffeeFlavor",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 3, "COFFEE_FLAVOR_PSL", "COFFEE FLAVOR PSL" },
                    { 1, "COFFEE_FLAVOR_VANILLA", "COFFEE FLAVOR VANILLA" },
                    { 2, "COFFEE_FLAVOR_CARAMEL", "COFFEE FLAVOR_CARAMEL" },
                    { 5, "COFFEE_FLAVOR_HAZELNUT", "COFFEE FLAVOR HAZELNUT" },
                    { 4, "COFFEE_FLAVOR_MOCHA", "COFFEE_FLAVOR_MOCHA" }
                });

            migrationBuilder.InsertData(
                schema: "CP",
                table: "tbCoffeePodPackSize",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 4, "DOZEN_7", "7 dozen (84)" },
                    { 3, "DOZEN_5", "5 dozen (60)" },
                    { 2, "DOZEN_3", "3 dozen (36)" },
                    { 1, "DOZEN_1", "1 dozen (12)" }
                });

            migrationBuilder.InsertData(
                schema: "CP",
                table: "tbProductType",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "COFFEE_POD_LARGE", "COFFEE POD LARGE" },
                    { 3, "ESPRESSO_POD", "ESPRESSO POD" },
                    { 2, "COFFEE_POD_SMALL", "COFFEE POD SMALL" }
                });

            migrationBuilder.InsertData(
                schema: "MC",
                table: "tbCoffeeMachineModel",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 3, "PREMIUM_MODEL", "PREMIUM" },
                    { 2, "DELUXE_MODEL", "DELUXE" },
                    { 1, "BASE_MODEL", "BASE" }
                });

            migrationBuilder.InsertData(
                schema: "MC",
                table: "tbProductType",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 3, "ESPRESSO_MACHINE", "ESPRESSO MACHINE" },
                    { 2, "COFFEE_MACHINE_SMALL", "COFFEE MACHINE SMALL" },
                    { 1, "COFFEE_MACHINE_LARGE", "COFFEE MACHINE LARGE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbCoffeePod_FlavorId",
                schema: "CP",
                table: "tbCoffeePod",
                column: "FlavorId");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoffeePod_PackSizeId",
                schema: "CP",
                table: "tbCoffeePod",
                column: "PackSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoffeePod_PodSKU",
                schema: "CP",
                table: "tbCoffeePod",
                column: "PodSKU",
                unique: true,
                filter: "[PodSKU] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoffeePod_ProductTypeId",
                schema: "CP",
                table: "tbCoffeePod",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoffeeMachine_MachineSKU",
                schema: "MC",
                table: "tbCoffeeMachine",
                column: "MachineSKU",
                unique: true,
                filter: "[MachineSKU] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoffeeMachine_ModelId",
                schema: "MC",
                table: "tbCoffeeMachine",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoffeeMachine_ProductTypeId",
                schema: "MC",
                table: "tbCoffeeMachine",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbCoffeePod",
                schema: "CP");

            migrationBuilder.DropTable(
                name: "tbCoffeeMachine",
                schema: "MC");

            migrationBuilder.DropTable(
                name: "tbCoffeeFlavor",
                schema: "CP");

            migrationBuilder.DropTable(
                name: "tbCoffeePodPackSize",
                schema: "CP");

            migrationBuilder.DropTable(
                name: "tbProductType",
                schema: "CP");

            migrationBuilder.DropTable(
                name: "tbCoffeeMachineModel",
                schema: "MC");

            migrationBuilder.DropTable(
                name: "tbProductType",
                schema: "MC");
        }
    }
}
