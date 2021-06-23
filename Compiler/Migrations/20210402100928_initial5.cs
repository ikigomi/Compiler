using Microsoft.EntityFrameworkCore.Migrations;

namespace Compiler.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Input",
                table: "Katas",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Input",
                value: "2, 6;4, 5;4, 7;100, 10");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Input",
                value: "2, 6; 4, 5; 4, 7; 100, 10");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Input",
                value: "2, 6; 5, 4; 4, 7; 100, 10");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Input",
                value: "6, 2; 8, 3; 4, 7; 100, -10");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Input",
                value: "4, 3; 4, 5; 12, 5; 100, 17");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Input",
                value: "2, 6; 4, 5; 4, 7; 100, 10");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Input",
                value: "2, 6; 4, 5; 4, 7; 100, 10");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 8,
                column: "Input",
                value: "2, 6; 5, 4; 4, 7; 100, 10");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Input",
                value: "6, 2; 8, 3; 4, 7; 100, -10");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Input",
                value: "4, 3; 4, 5; 12, 5; 100, 17");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Input",
                table: "Katas");
        }
    }
}
