using Microsoft.EntityFrameworkCore.Migrations;

namespace Intergration.Migrations
{
    public partial class NewCommentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CallComments_Customers_CustomerIDId",
                table: "CallComments");

            migrationBuilder.DropColumn(
                name: "CusomerID",
                table: "CallComments");

            migrationBuilder.RenameColumn(
                name: "CustomerIDId",
                table: "CallComments",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CallComments_CustomerIDId",
                table: "CallComments",
                newName: "IX_CallComments_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CallComments_Customers_CustomerId",
                table: "CallComments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CallComments_Customers_CustomerId",
                table: "CallComments");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "CallComments",
                newName: "CustomerIDId");

            migrationBuilder.RenameIndex(
                name: "IX_CallComments_CustomerId",
                table: "CallComments",
                newName: "IX_CallComments_CustomerIDId");

            migrationBuilder.AddColumn<int>(
                name: "CusomerID",
                table: "CallComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CallComments_Customers_CustomerIDId",
                table: "CallComments",
                column: "CustomerIDId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
