using Microsoft.EntityFrameworkCore.Migrations;

namespace Intergration.Migrations
{
    public partial class Comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CallComment",
                table: "Customers");

            migrationBuilder.CreateTable(
                name: "CallComments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CusomerID = table.Column<int>(type: "int", nullable: false),
                    CustomerIDId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CallComments_Customers_CustomerIDId",
                        column: x => x.CustomerIDId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CallComments_CustomerIDId",
                table: "CallComments",
                column: "CustomerIDId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CallComments");

            migrationBuilder.AddColumn<string>(
                name: "CallComment",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
