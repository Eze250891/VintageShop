using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VintageShop.Migrations
{
    /// <inheritdoc />
    public partial class AgregramosColumnasTalle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Talle",
                table: "Zapatos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Talle",
                table: "Zapatos");
        }
    }
}
