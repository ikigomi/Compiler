using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;
using Compiler.Domain.Entities;

namespace Compiler
{
    public class Databaseinitializer
    {
        public static void Init(IServiceProvider scopeServiceProvider)
        {
            var userManager = scopeServiceProvider.GetService<UserManager<ApplicationUser>>();


            var user = new ApplicationUser
            {
                Email = "test@mail.ru",
                EmailConfirmed = true,
                UserName = "Admin",
                LastName = "admin",
                FirstName = "igor",
                Group = "485"
            };

            var result = userManager.CreateAsync(user, "123qwe").GetAwaiter().GetResult();
            if (result.Succeeded)
            {
                userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "Administrator")).GetAwaiter().GetResult();
            }

            var user2 = new ApplicationUser
            {
                Email = "test2@mail.ru",
                EmailConfirmed = true,
                UserName = "User",
                LastName = "user",
                FirstName = "igor",
                Group = "485"
            };

            userManager.CreateAsync(user2, "123123").GetAwaiter().GetResult();
            if (result.Succeeded)
            {
                userManager.AddClaimAsync(user2, new Claim(ClaimTypes.Role, "User")).GetAwaiter().GetResult();
            }
        }
    }
}