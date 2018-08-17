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
    public class JournalController : Controller
    {
        // GET: Journal
        public ActionResult Index(int id)
        {
            var ownerId = Guid.Parse(User.Identity.GetUserId());
            var svc = new CharacterService(ownerId);
            var service = new JournalService(ownerId, id);

            ViewBag.CharacterName = svc.GetCharacterById(id).CharacterName;

            return View(service.GetJournals());
        }

        public ActionResult Create(int id)
        {
            var model = new JournalCreate
            {
                CharacterId = id,
                OwnerId = Guid.Parse(User.Identity.GetUserId())
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JournalCreate journal)
        {
            if (!ModelState.IsValid) return View(journal);

            var service = CreateJournalService(journal);

            if (service.CreateJournalEntry(journal))
            {
                TempData["SaveResult"] = "Your journal entry was created.";
                return RedirectToAction("Index", "Journal", new { id = journal.CharacterId });
            }

            ModelState.AddModelError("", "Journal entry could not be created.");

            return View(journal);
        }

        private JournalService CreateJournalService(JournalCreate journal)
        {
            var ownerId = Guid.Parse(User.Identity.GetUserId());
            var service = new JournalService(ownerId, journal.CharacterId);
            return service;
        }
    }
}