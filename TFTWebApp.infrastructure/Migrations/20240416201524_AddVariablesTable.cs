using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFTWebApp.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddVariablesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rule",
                table: "Abilities");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Variables",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Variables",
                newName: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "value",
                table: "Variables",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Variables",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Rule",
                table: "Abilities",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
