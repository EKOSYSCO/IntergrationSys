using Microsoft.EntityFrameworkCore.Migrations;

namespace Intergration.Migrations
{
    public partial class INITII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CallComment",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CallComment",
                table: "Customers");
        }
    }
}
