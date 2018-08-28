using CharacterManager.Data;
using CharacterManager.Models.CharacterModels;
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
        // GET: Character
        public ActionResult Index()
        {
            var service = CreateCharacterService();
            var model = service.GetCharacters();
            return View(model);
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

        public ActionResult Details(int id)
        {
            var service = CreateCharacterService();
            var model = service.GetCharacterById(id);

            ViewBag.CharacterName = model.CharacterName;

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateCharacterService();
            var detail = service.GetCharacterById(id);

            var model = new CharacterEdit
            {
                CharacterId = detail.CharacterId,
                CharacterName = detail.CharacterName,
                CharacterRace = detail.CharacterRace,
                CharacterGender = detail.CharacterGender,
                CharacterClass = detail.CharacterClass,
                Alignment = detail.Alignment,
                PersonalityTraits = detail.PersonalityTraits,
                Ideals = detail.Ideals,
                Bonds = detail.Bonds,
                Flaws = detail.Flaws,
                HitPoints = detail.HitPoints
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CharacterEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.CharacterId != id)
            {
                ModelState.AddModelError("", "Id mismatch.");
                return View(model);
            }

            var service = CreateCharacterService();

            if (service.UpdateCharacter(model))
            {
                TempData["SaveResult"] = "Your character has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your character could not be updated.");
            return View();
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var service = CreateCharacterService();
            var model = service.GetCharacterById(id);
            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCharacter(int id)
        {
            var service = CreateCharacterService();

            service.DeleteCharacater(id);

            TempData["SaveResult"] = "Your character was deleted.";

            return RedirectToAction("Index");
        }

        private CharacterService CreateCharacterService()
        {
            var ownerId = Guid.Parse(User.Identity.GetUserId());
            return new CharacterService(ownerId);
        }
    }
}