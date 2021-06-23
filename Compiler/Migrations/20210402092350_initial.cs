using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Compiler.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Katas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    InitialCode = table.Column<string>(nullable: true),
                    InputData = table.Column<string>(nullable: false),
                    OutputData = table.Column<string>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Katas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Katas_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attempts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxAttempts = table.Column<int>(nullable: false),
                    CurrentAttempts = table.Column<int>(nullable: false),
                    IsSolved = table.Column<bool>(nullable: false),
                    KataId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attempts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attempts_Katas_KataId",
                        column: x => x.KataId,
                        principalTable: "Katas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attempts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    KataId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_Katas_KataId",
                        column: x => x.KataId,
                        principalTable: "Katas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Logs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "CSharp" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Python3" });

            migrationBuilder.InsertData(
                table: "Katas",
                columns: new[] { "Id", "Description", "InitialCode", "InputData", "LanguageId", "Name", "OutputData" },
                values: new object[,]
                {
                    { 1, @"Вам нужно написать функцию для умножения двух чисел.
                Например, входные данные: 2, 6Результат: 12", @"using System;
                                                public class Test
                                                {
                                                    static public void Main()
                                                    {
                                                        //ввод чисел
                                                        int a = Convert.ToInt32(Console.ReadLine());
                                                        int b = Convert.ToInt32(Console.ReadLine());
                                                        //код

                                                        Console.WriteLine();  //результат
                                                    }
                                                }", "2, 6; 4, 5; 4, 7; 100, 10", 1, "Умножение чисел", "12; 20; 28; 1000" },
                    { 2, @"Вам нужно написать функцию для сложения двух чисел.
                Например, входные данные: 2, 6Результат: 8", @"using System;
                                                public class Test
                                                {
                                                    static public void Main()
                                                    {
                                                        //ввод чисел
                                                        int a = Convert.ToInt32(Console.ReadLine());
                                                        int b = Convert.ToInt32(Console.ReadLine());
                                                        //код

                                                        Console.WriteLine(); //результат
                                                    }
                                                }", "2, 6; 4, 5; 4, 7; 100, 10", 1, "Сложение чисел", "8; 9; 11; 110" },
                    { 3, @"Вам нужно написать функцию для разности двух чисел.
                Например, входные данные: 2, 6Результат: -4Функция должна выводить на консоль произведение чисел", @"using System;
                                                public class Test
                                                {
                                                    static public void Main()
                                                    {
                                                        //ввод чисел
                                                        int a = Convert.ToInt32(Console.ReadLine());
                                                        int b = Convert.ToInt32(Console.ReadLine());
                                                        //код

                                                        Console.WriteLine(); //результат
                                                    }
                                                }", "2, 6; 5, 4; 4, 7; 100, 10", 1, "Разность чисел", "-4; 1; -3; 90" },
                    { 4, @"Вам нужно написать функцию для деления двух чисел.
                Например, входные данные: 6, 2Результат: 3Функция должна выводить на консоль произведение чисел", @"using System;
                                                public class Test
                                                {
                                                    static public void Main()
                                                    {
                                                        //ввод чисел
                                                        int a = Convert.ToInt32(Console.ReadLine());
                                                        int b = Convert.ToInt32(Console.ReadLine());
                                                        //код

                                                        Console.WriteLine(); //результат
                                                    }
                                                }", "6, 2; 8, 3; 4, 7; 100, -10", 1, "Деление чисел", "3; 2; 0; -10" },
                    { 5, @"Вам нужно написать функцию для нахождения остатка от двух чисел.
                Например, входные данные: 4, 3Результат: 1Функция должна выводить на консоль произведение чисел", @"using System;
                                                public class Test
                                                {
                                                    static public void Main()
                                                    {
                                                        //ввод чисел
                                                        int a = Convert.ToInt32(Console.ReadLine());
                                                        int b = Convert.ToInt32(Console.ReadLine());
                                                        //код

                                                        Console.WriteLine(); //результат
                                                    }
                                                }", "4, 3; 4, 5; 12, 5; 100, 17", 1, "Остаток чисел", "1; 4; 2; 15" },
                    { 6, @"Вам нужно написать функцию для умножения двух чисел.
                Например, входные данные: 2, 6Результат: 12", @"#ввод
                                                    a = int(input())
                                                    b = int(input())
                                                    #код

                                                    print() #результат", "2, 6; 4, 5; 4, 7; 100, 10", 2, "Умножение чисел", "12; 20; 28; 1000" },
                    { 7, @"Вам нужно написать функцию для сложения двух чисел.
                Например, входные данные: 2, 6Результат: 8", @"#ввод
                                                    a = int(input())
                                                    b = int(input())
                                                    #код

                                                    print() #результат", "2, 6; 4, 5; 4, 7; 100, 10", 2, "Сложение чисел", "8; 9; 11; 110" },
                    { 8, @"Вам нужно написать функцию для разности двух чисел.
                Например, входные данные: 2, 6Результат: -4Функция должна выводить на консоль произведение чисел", @"#ввод
                                                    a = int(input())
                                                    b = int(input())
                                                    #код

                                                    print() #результат", "2, 6; 5, 4; 4, 7; 100, 10", 2, "Разность чисел", "-4; 1; -3; 90" },
                    { 9, @"Вам нужно написать функцию для деления двух чисел.
                Например, входные данные: 6, 2Результат: 3Функция должна выводить на консоль произведение чисел", @"#ввод
                                                    a = int(input())
                                                    b = int(input())
                                                    #код

                                                    print() #результат", "6, 2; 8, 3; 4, 7; 100, -10", 2, "Деление чисел", "3; 2; 0; -10" },
                    { 10, @"Вам нужно написать функцию для нахождения остатка от двух чисел.
                Например, входные данные: 4, 3Результат: 1Функция должна выводить на консоль произведение чисел", @"#ввод
                                                    a = int(input())
                                                    b = int(input())
                                                    #код

                                                    print() #результат", "4, 3; 4, 5; 12, 5; 100, 17", 2, "Остаток чисел", "1; 4; 2; 15" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attempts_KataId",
                table: "Attempts",
                column: "KataId");

            migrationBuilder.CreateIndex(
                name: "IX_Attempts_UserId",
                table: "Attempts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Katas_LanguageId",
                table: "Katas",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_KataId",
                table: "Logs",
                column: "KataId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserId",
                table: "Logs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Attempts");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Katas");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
