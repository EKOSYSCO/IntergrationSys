using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intergration.Migrations
{
    public partial class INIT4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CallDate",
                table: "CallComments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CallComments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CallDate",
                table: "CallComments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CallComments");
        }
    }
}
