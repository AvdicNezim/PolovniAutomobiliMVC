using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolovniAutomobiliMVC.Migrations
{
    /// <inheritdoc />
    public partial class addedShoppingCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_FuelTypes_fuelTypeId",
                table: "cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FuelTypes",
                table: "FuelTypes");

            migrationBuilder.RenameTable(
                name: "FuelTypes",
                newName: "fuelTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fuelTypes",
                table: "fuelTypes",
                column: "id");

            migrationBuilder.CreateTable(
                name: "shoppingCartItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carid = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    shoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppingCartItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_shoppingCartItems_cars_carid",
                        column: x => x.carid,
                        principalTable: "cars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCartItems_carid",
                table: "shoppingCartItems",
                column: "carid");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_fuelTypes_fuelTypeId",
                table: "cars",
                column: "fuelTypeId",
                principalTable: "fuelTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_fuelTypes_fuelTypeId",
                table: "cars");

            migrationBuilder.DropTable(
                name: "shoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_fuelTypes",
                table: "fuelTypes");

            migrationBuilder.RenameTable(
                name: "fuelTypes",
                newName: "FuelTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FuelTypes",
                table: "FuelTypes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_FuelTypes_fuelTypeId",
                table: "cars",
                column: "fuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
