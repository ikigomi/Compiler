using Compiler.Domain.CoreCompiler.ApiModels;
using Compiler.Domain.Entities;
using Compiler.Domain.Entities.Logs;
using Compiler.Domain.Entities.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Compiler.Domain.Repositories
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Kata> Katas { get; set; }
        public DbSet<ProgrammingLanguage> Languages { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<Attempt> Attempts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProgrammingLanguage>().HasData(new ProgrammingLanguage {Id=1, Name=Language.CSharp.ToString() });

            modelBuilder.Entity<ProgrammingLanguage>().HasData(new ProgrammingLanguage {Id=2, Name=Language.Python3.ToString() });



            modelBuilder.Entity<Kata>().HasData(new Kata
            {
                Id = 1,
                Name = "Умножение чисел",
                Description = "Вам нужно написать функцию для умножения двух чисел." +
                                "\nНапример, входные данные: 2, 6" +
                                "Результат: 12",
                InitialCode = @"using System;
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
                                }",

                InputData = new List<string> { { "2, 6" }, { "4, 5" }, { "4, 7" }, { "100, 10" } }.ToArray(),
                OutputData = "12; 20; 28; 1000".Split(';'),
                LanguageId = 1
            });

            modelBuilder.Entity<Kata>().HasData(new Kata
            {
                Id = 2,
                Name = "Сложение чисел",
                Description = "Вам нужно написать функцию для сложения двух чисел." +
                                "\nНапример, входные данные: 2, 6" +
                                "Результат: 8",
                InitialCode = @"using System;
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
                                }",

                InputData = "2, 6; 4, 5; 4, 7; 100, 10".Split(';'),
                OutputData = "8; 9; 11; 110".Split(';'),
                LanguageId = 1
            });

            modelBuilder.Entity<Kata>().HasData(new Kata
            {
                Id = 3,
                Name = "Разность чисел",
                Description = "Вам нужно написать функцию для разности двух чисел." +
                                "\nНапример, входные данные: 2, 6" +
                                "Результат: -4" +
                                "Функция должна выводить на консоль произведение чисел",

                InitialCode = @"using System;
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
                                }",

                InputData = "2, 6; 5, 4; 4, 7; 100, 10".Split(';'),
                OutputData = "-4; 1; -3; 90".Split(';'),
                LanguageId = 1
            });

            modelBuilder.Entity<Kata>().HasData(new Kata
            {
                Id = 4,
                Name = "Деление чисел",
                Description = "Вам нужно написать функцию для деления двух чисел." +
                                "\nНапример, входные данные: 6, 2" +
                                "Результат: 3" +
                                "Функция должна выводить на консоль произведение чисел",
                InitialCode = @"using System;
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
                                }",

                InputData = "6, 2; 8, 3; 4, 7; 100, -10".Split(';'),
                OutputData = "3; 2; 0; -10".Split(';'),
                LanguageId = 1
            });

            modelBuilder.Entity<Kata>().HasData(new Kata
            {
                Id = 5,
                Name = "Остаток чисел",
                Description = "Вам нужно написать функцию для нахождения остатка от двух чисел." +
                                "\nНапример, входные данные: 4, 3" +
                                "Результат: 1" +
                                "Функция должна выводить на консоль произведение чисел",
                InitialCode = @"using System;
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
                                }",

                InputData = "4, 3; 4, 5; 12, 5; 100, 17".Split(';'),
                OutputData = "1; 4; 2; 15".Split(';'),
                LanguageId = 1
            });

            modelBuilder.Entity<Kata>().HasData(new Kata
            {
                Id = 6,
                Name = "Умножение чисел",
                Description = "Вам нужно написать функцию для умножения двух чисел." +
                                "\nНапример, входные данные: 2, 6" +
                                "Результат: 12",
                InitialCode = @"#ввод
                                    a = int(input())
                                    b = int(input())
                                    #код

                                    print() #результат",

                InputData = "2, 6; 4, 5; 4, 7; 100, 10".Split(';'),
                OutputData = "12; 20; 28; 1000".Split(';'),
                LanguageId = 2
            });

            modelBuilder.Entity<Kata>().HasData(new Kata
            {
                Id = 7,
                Name = "Сложение чисел",
                Description = "Вам нужно написать функцию для сложения двух чисел." +
                                "\nНапример, входные данные: 2, 6" +
                                "Результат: 8",
                InitialCode = @"#ввод
                                    a = int(input())
                                    b = int(input())
                                    #код

                                    print() #результат",

                InputData = "2, 6; 4, 5; 4, 7; 100, 10".Split(';'),
                OutputData = "8; 9; 11; 110".Split(';'),
                LanguageId = 2
            });

            modelBuilder.Entity<Kata>().HasData(new Kata
            {
                Id = 8,
                Name = "Разность чисел",
                Description = "Вам нужно написать функцию для разности двух чисел." +
                                "\nНапример, входные данные: 2, 6" +
                                "Результат: -4" +
                                "Функция должна выводить на консоль произведение чисел",

                InitialCode = @"#ввод
                                    a = int(input())
                                    b = int(input())
                                    #код

                                    print() #результат",

                InputData = "2, 6; 5, 4; 4, 7; 100, 10".Split(';'),
                OutputData = "-4; 1; -3; 90".Split(';'),
                LanguageId = 2
            });

            modelBuilder.Entity<Kata>().HasData(new Kata
            {
                Id = 9,
                Name = "Деление чисел",
                Description = "Вам нужно написать функцию для деления двух чисел." +
                                "\nНапример, входные данные: 6, 2" +
                                "Результат: 3" +
                                "Функция должна выводить на консоль произведение чисел",
                InitialCode = @"#ввод
                                    a = int(input())
                                    b = int(input())
                                    #код

                                    print() #результат",

                InputData = "6, 2; 8, 3; 4, 7; 100, -10".Split(';'),
                OutputData = "3; 2; 0; -10".Split(';'),
                LanguageId = 2
            });

            modelBuilder.Entity<Kata>().HasData(new Kata
            {
                Id = 10,
                Name = "Остаток чисел",
                Description = "Вам нужно написать функцию для нахождения остатка от двух чисел." +
                                "\nНапример, входные данные: 4, 3" +
                                "Результат: 1" +
                                "Функция должна выводить на консоль произведение чисел",
                InitialCode = @"#ввод
                                    a = int(input())
                                    b = int(input())
                                    #код

                                    print() #результат",

                InputData = "4, 3; 4, 5; 12, 5; 100, 17".Split(';'),
                OutputData = "1; 4; 2; 15".Split(';'),
                LanguageId = 2
            });
        }

        
    }
}
