using CharacterManager.Models.JournalModels;
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
            var svc = new CharacterService(GetGuid());
            var service = new JournalService(GetGuid(), id);

            ViewBag.CharacterName = svc.GetCharacterById(id).CharacterName;

            return View(service.GetJournals());
        }

        public ActionResult Create(int id)
        {
            var model = new JournalCreate
            {
                CharacterId = id,
                OwnerId = GetGuid()
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

        public ActionResult Details(int id)
        {
            var service = new JournalService(GetGuid(), id).GetJournalById(id);

            ViewBag.CharacterName = service.Title;

            return View(service);
        }

        public ActionResult Edit(int id)
        {
            var service = new JournalService(GetGuid()).GetJournalById(id);

            var model = new JournalEdit
            {
                JournalId = service.JournalId,
                CharacterId = service.CharacterId,
                Title = service.Title,
                Content = service.Content,
                ModifiedUtc = DateTimeOffset.Now
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, JournalEdit journal)
        {
            if (!ModelState.IsValid) return View(journal);

            if (journal.JournalId != id)
            {
                ModelState.AddModelError("", "Id mismatch.");
                return View(journal);
            }

            var service = new JournalService(GetGuid());
            var journalId = service.GetJournalById(id);

            if (service.UpdateJournalEntry(journal))
            {
                TempData["SaveResult"] = "Your character has been updated.";
                return RedirectToAction("Index", "Journal", new { id = journalId.CharacterId });
            }

            ModelState.AddModelError("", "Your character could not be updated.");
            return View();
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var journal = new JournalService(GetGuid()).GetJournalById(id);
            return View(journal);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteJournal(int id)
        {
            var service = new JournalService(GetGuid());
            var journalId = service.GetJournalById(id);

            service.DeleteJournalEntry(id);

            TempData["SaveResult"] = "Your journal entry was deleted.";

            return RedirectToAction("Index", new { id = journalId.CharacterId });
        }

        private JournalService CreateJournalService(JournalCreate journal)
        {
            var service = new JournalService(GetGuid(), journal.CharacterId);
            return service;
        }

        private Guid GetGuid()
        {
            return Guid.Parse(User.Identity.GetUserId());
        }
    }
}