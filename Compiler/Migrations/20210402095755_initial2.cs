using Microsoft.EntityFrameworkCore.Migrations;

namespace Compiler.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InputData",
                table: "Katas");

            migrationBuilder.DropColumn(
                name: "OutputData",
                table: "Katas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InputData",
                table: "Katas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OutputData",
                table: "Katas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InputData", "OutputData" },
                values: new object[] { "2, 6; 4, 5; 4, 7; 100, 10", "12; 20; 28; 1000" });

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InputData", "OutputData" },
                values: new object[] { "2, 6; 4, 5; 4, 7; 100, 10", "8; 9; 11; 110" });

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InputData", "OutputData" },
                values: new object[] { "2, 6; 5, 4; 4, 7; 100, 10", "-4; 1; -3; 90" });

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InputData", "OutputData" },
                values: new object[] { "6, 2; 8, 3; 4, 7; 100, -10", "3; 2; 0; -10" });

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InputData", "OutputData" },
                values: new object[] { "4, 3; 4, 5; 12, 5; 100, 17", "1; 4; 2; 15" });

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InputData", "OutputData" },
                values: new object[] { "2, 6; 4, 5; 4, 7; 100, 10", "12; 20; 28; 1000" });

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InputData", "OutputData" },
                values: new object[] { "2, 6; 4, 5; 4, 7; 100, 10", "8; 9; 11; 110" });

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InputData", "OutputData" },
                values: new object[] { "2, 6; 5, 4; 4, 7; 100, 10", "-4; 1; -3; 90" });

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InputData", "OutputData" },
                values: new object[] { "6, 2; 8, 3; 4, 7; 100, -10", "3; 2; 0; -10" });

            migrationBuilder.UpdateData(
                table: "Katas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InputData", "OutputData" },
                values: new object[] { "4, 3; 4, 5; 12, 5; 100, 17", "1; 4; 2; 15" });
        }
    }
}
