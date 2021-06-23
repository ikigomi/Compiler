using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Compiler.Domain.Entities;
using Compiler.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Compiler.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {          
            return View(new LoginViewModel { returnUrl = "/Home" });
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

                    if (result.Succeeded)
                    {
                        return Redirect(model.returnUrl ?? "/");
                    }
                }
                ModelState.AddModelError("", "Неверный логин или пароль");
            }        
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View(new RegisterViewModel { returnUrl = "/home" });
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model != null)
                {
                    var user = new ApplicationUser
                    {
                        Email = model.Email,
                        UserName = model.UserName,
                        LastName = model.LastName,
                        FirstName = model.FirstName,
                        Group = model.Group
                    };

                    var registerResult = await _userManager.CreateAsync(user, model.Password);
                    if (registerResult.Succeeded)
                    {
                        await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "User"));
                        await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
                        return Redirect(model.returnUrl ?? "/");
                    }
                    else
                    {
                        string errors = "";
                        foreach (var item in registerResult.Errors)
                        {
                            errors += item.Description += "\n";
                        }
                        ModelState.AddModelError("", errors);
                    }
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Home");
        }
    }
}
