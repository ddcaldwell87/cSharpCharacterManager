using CharacterManager.Data;
using CharacterManager.Models;
using CharacterManager.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterManager.WebMVC.Controllers
{
    [Authorize]
    public class CharacterController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Character
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CharacterCreate model)
        {
            

            if (!ModelState.IsValid) return View(model);

            var service = CreateCharacterService();

            if (service.CharacterCreate(model))
            {
                TempData["SaveResult"] = "Your character was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Character could not be created.");

            return View(model);
        }

        private CharacterService CreateCharacterService()
        {
            var ownerId = Guid.Parse(User.Identity.GetUserId());
            return new CharacterService(ownerId);
        }
    }
}