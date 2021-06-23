using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Compiler.Domain.CoreCompiler;
using Compiler.Domain.Entities.Logs;
using Compiler.Domain.Repositories;
using Compiler.Models;
using Microsoft.AspNetCore.Mvc;

namespace Compiler.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            var data = new HomeViewModel
            {
                Katas = dataManager.Katas.GetKatas(),
                Languages = dataManager.Languages.GetLanguages()
            };
            return View(data);
        }

        public IActionResult Solve(string code, int id)
        {
            var kata = dataManager.Katas.GetKataById(id);
            kata.Language = dataManager.Languages.GetLanguageById(kata.LanguageId);
            var currentUser = dataManager.Users.GetUserByLogin(User.Identity.Name);
            var attempt = dataManager.Attempts.GetAttempt(currentUser.Id, kata.Id);

            if (attempt != null && attempt.CurrentAttempts >= attempt.MaxAttempts)
            {
                TempData["DeniedMessage"] = "Достигнуто максимальное количество попыток";
                return Redirect("/Home/AccessDenied");
            }

            if (code == null)
                return View(new KataSolutionViewModel { Kata = kata});

            var solution = CoreCompiler.Solve(code, kata);

            var logs = new Logs
            {
                KataId = kata.Id,
                UserId = dataManager.Users.GetUserByLogin(User.Identity.Name).Id,
                Code = code               
            };


            dataManager.Attempts.IncrementCurrentAttempt(logs.UserId, logs.KataId, solution.IsSolved);

            dataManager.Logs.SaveLogs(logs);

            return View(solution);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }

}
