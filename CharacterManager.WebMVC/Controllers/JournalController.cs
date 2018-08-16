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
        public ActionResult Index(int characterId)
        {
            var ownerId = Guid.Parse(User.Identity.GetUserId());
            var service = new JournalService(ownerId, characterId);
            return View(service.GetJournals());
        }

        public ActionResult Create(int characterId)
        {
            var model = new JournalCreate
            {
                CharacterId = characterId,
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
                return RedirectToAction("Details", "Character", new { id = journal.CharacterId });
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