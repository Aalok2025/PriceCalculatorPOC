using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PriceCalculatorPOC.Migrations
{
    /// <inheritdoc />
    public partial class updateschema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomizationFeatures_InteriorElements_ElementId",
                table: "CustomizationFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Selections_InteriorElements_ElementId",
                table: "Selections");

            migrationBuilder.DropColumn(
                name: "Options",
                table: "FixedUnits");

            migrationBuilder.DropColumn(
                name: "Options",
                table: "CustomizationFeatures");

            migrationBuilder.RenameColumn(
                name: "SelectedOptions",
                table: "Selections",
                newName: "SelectedInteriorElementIds");

            migrationBuilder.RenameColumn(
                name: "ElementId",
                table: "Selections",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "SelectionId",
                table: "Selections",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Selections_ElementId",
                table: "Selections",
                newName: "IX_Selections_RoomId");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Rooms",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ElementId",
                table: "InteriorElements",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "FixedUnits",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ElementId",
                table: "CustomizationFeatures",
                newName: "InteriorElementId");

            migrationBuilder.RenameColumn(
                name: "FeatureId",
                table: "CustomizationFeatures",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_CustomizationFeatures_ElementId",
                table: "CustomizationFeatures",
                newName: "IX_CustomizationFeatures_InteriorElementId");

            migrationBuilder.AddColumn<string>(
                name: "SelectedCustomizationFeatureIds",
                table: "Selections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "SelectedFeatureFieldIds",
                table: "Selections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "SelectedFixedUnitFieldIds",
                table: "Selections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "SelectedFixedUnitIds",
                table: "Selections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.CreateTable(
                name: "FeatureFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CustomizationFeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeatureFields_CustomizationFeatures_CustomizationFeatureId",
                        column: x => x.CustomizationFeatureId,
                        principalTable: "CustomizationFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FixedUnitFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    FixedUnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedUnitFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FixedUnitFields_FixedUnits_FixedUnitId",
                        column: x => x.FixedUnitId,
                        principalTable: "FixedUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeatureFields_CustomizationFeatureId",
                table: "FeatureFields",
                column: "CustomizationFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedUnitFields_FixedUnitId",
                table: "FixedUnitFields",
                column: "FixedUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomizationFeatures_InteriorElements_InteriorElementId",
                table: "CustomizationFeatures",
                column: "InteriorElementId",
                principalTable: "InteriorElements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Selections_Rooms_RoomId",
                table: "Selections",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomizationFeatures_InteriorElements_InteriorElementId",
                table: "CustomizationFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Selections_Rooms_RoomId",
                table: "Selections");

            migrationBuilder.DropTable(
                name: "FeatureFields");

            migrationBuilder.DropTable(
                name: "FixedUnitFields");

            migrationBuilder.DropColumn(
                name: "SelectedCustomizationFeatureIds",
                table: "Selections");

            migrationBuilder.DropColumn(
                name: "SelectedFeatureFieldIds",
                table: "Selections");

            migrationBuilder.DropColumn(
                name: "SelectedFixedUnitFieldIds",
                table: "Selections");

            migrationBuilder.DropColumn(
                name: "SelectedFixedUnitIds",
                table: "Selections");

            migrationBuilder.RenameColumn(
                name: "SelectedInteriorElementIds",
                table: "Selections",
                newName: "SelectedOptions");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Selections",
                newName: "ElementId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Selections",
                newName: "SelectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Selections_RoomId",
                table: "Selections",
                newName: "IX_Selections_ElementId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rooms",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "InteriorElements",
                newName: "ElementId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FixedUnits",
                newName: "UnitId");

            migrationBuilder.RenameColumn(
                name: "InteriorElementId",
                table: "CustomizationFeatures",
                newName: "ElementId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CustomizationFeatures",
                newName: "FeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomizationFeatures_InteriorElementId",
                table: "CustomizationFeatures",
                newName: "IX_CustomizationFeatures_ElementId");

            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "FixedUnits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "CustomizationFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomizationFeatures_InteriorElements_ElementId",
                table: "CustomizationFeatures",
                column: "ElementId",
                principalTable: "InteriorElements",
                principalColumn: "ElementId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Selections_InteriorElements_ElementId",
                table: "Selections",
                column: "ElementId",
                principalTable: "InteriorElements",
                principalColumn: "ElementId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
