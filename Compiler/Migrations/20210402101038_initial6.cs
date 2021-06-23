using Microsoft.EntityFrameworkCore.Migrations;

namespace Compiler.Migrations
{
    public partial class initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Output",
                table: "Katas",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Output",
                value: "12; 20; 28; 1000");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Output",
                value: "8; 9; 11; 110");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Output",
                value: "-4; 1; -3; 90");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Output",
                value: "3; 2; 0; -10");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Output",
                value: "1; 4; 2; 15");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Output",
                value: "12; 20; 28; 1000");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Output",
                value: "8; 9; 11; 110");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 8,
                column: "Output",
                value: "-4; 1; -3; 90");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Output",
                value: "3; 2; 0; -10");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Output",
                value: "1; 4; 2; 15");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Output",
                table: "Katas");
        }
    }
}
