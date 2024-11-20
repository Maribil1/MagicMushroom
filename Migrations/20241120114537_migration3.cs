using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicMushroom.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mushroom",
                table: "Character");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mushroom",
                table: "Character",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
