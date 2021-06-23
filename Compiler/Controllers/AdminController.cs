using Compiler.Domain.Entities;
using Compiler.Domain.Entities.Logs;
using Compiler.Domain.Entities.Tasks;
using Compiler.Domain.Repositories;
using Compiler.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Compiler.Controllers
{
    [Authorize(Policy = "Administrator")]
    public class AdminController:Controller
    {
        private readonly DataManager dataManager;

        public AdminController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            var katas = dataManager.Katas.GetKatas();
            foreach (var kata in katas)
            {
                kata.Language = dataManager.Languages.GetLanguageById(kata.LanguageId);
            }
            return View(katas);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Languages = new SelectList(dataManager.Languages.GetLanguages(), "Id", "Name");
            if (id == default)
            {
                return View(new Kata());
            }
            var kata = dataManager.Katas.GetKataById(id);
            kata.Language = dataManager.Languages.GetLanguageById(kata.LanguageId);
            return View(kata);
        }

        [HttpPost]
        public IActionResult Edit(Kata kata)
        {
            ViewBag.Languages = new SelectList(dataManager.Languages.GetLanguages(), "Id", "Name");
            if (ModelState.IsValid)
            {
                dataManager.Katas.SaveKata(kata);
                return Redirect("/Admin/Index");
            }
            return View(kata);
        }

        public IActionResult Users()
        {
            return View(dataManager.Users.GetUsers().OrderBy(x=>x.Group).ToList());
        }

        public IActionResult AttemptsEdit(string id)
        {
            var attempts = new List<Attempt>();
            foreach (var item in dataManager.Attempts.GetAttempts().Where(x => x.UserId == id).OrderByDescending(x=>x.Id))
            {
                if (attempts.FirstOrDefault(x => x.KataId == item.KataId) == null)
                {
                    var temp = item;
                    temp.Kata = dataManager.Katas.GetKataById(item.KataId);
                    temp.Kata.Language = dataManager.Languages.GetLanguageById(temp.Kata.LanguageId);
                    attempts.Add(temp);
                }

            }
            return View(attempts);
        }

        public IActionResult Stats(string id)
        {
            var attempts = dataManager.Attempts.GetAttempts().Where(x=>x.UserId==id).ToList();
            var user = dataManager.Users.GetUserById(id);
            foreach (var item in attempts)
            {
                item.Kata = dataManager.Katas.GetKataById(item.KataId);
                item.Kata.Language = dataManager.Languages.GetLanguageById(item.Kata.LanguageId);
                item.User = user;
            }
            return View(attempts);
        }

        [HttpPost]
        public IActionResult AttemptsEdit(int number, string userId, int kataId)
        {
            if (ModelState.IsValid)
            {
                dataManager.Attempts.IncreaseMaxAttemptsNumber(userId, kataId, number);
                return Redirect("/Admin/Users");

            }
            return Redirect("/Admin/Index");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            dataManager.Katas.DeleteKata(id);
            return Redirect("/Admin/Index");
        }
    }
}
