using CharacterManager.Contracts;
using CharacterManager.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterManager.WebMVC.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index(int id)
        {
            var svc = new CharacterService(GetGuid());
            var service = new InventoryService(GetGuid(), id);

            ViewBag.CharacterName = svc.GetCharacterById(id).CharacterName;

            return View(service.GetInventory());
        }

        public ActionResult Create(int id)
        {
            var model = new InventoryCreate
            {
                CharacterId = id,
                OwnerId = GetGuid()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InventoryCreate item)
        {
            if (!ModelState.IsValid) return View(item);

            var service = CreateInventoryService(item);

            if (service.InventoryItemCreate(item))
            {
                TempData["SaveResult"] = "Your item was created.";
                return RedirectToAction("Index", new { id = item.CharacterId });
            }

            ModelState.AddModelError("", "Item was not created.");

            return View(item);
        }

        public ActionResult Details(int id)
        {
            var service = new InventoryService(GetGuid()).GetInventoryItemById(id);
            
            return View(service);
        }

        public ActionResult Edit(int id)
        {
            var service = new InventoryService(GetGuid()).GetInventoryItemById(id);

            var model = new InventoryEdit
            {
                CharacterId = service.CharacterId,
                InventoryId = service.InventoryId,
                ItemName = service.ItemName,
                ItemQuantity = service.ItemQuantity,
                ItemType = service.ItemType
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, InventoryEdit item)
        {
            if (!ModelState.IsValid) return View(item);

            if (item.InventoryId != id)
            {
                ModelState.AddModelError("", "Id mismatch.");
                return View(item);
            }
            
            var service = new InventoryService(GetGuid());
            var inventory = service.GetInventoryItemById(id);

            if (service.UpdateInventoryItem(item))
            {
                TempData["SaveResult"] = "Your item was updated.";
                return RedirectToAction("Index", new { id = inventory.CharacterId });
            }

            ModelState.AddModelError("", "Your item could not be updated.");
            return View(item);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var item = new InventoryService(GetGuid()).GetInventoryItemById(id);
            return View(item);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(int id)
        {
            var service = new InventoryService(GetGuid());
            var inventory = service.GetInventoryItemById(id);

            service.DeleteInventory(id);
            TempData["SaveResult"] = "Your item was deleted.";

            return RedirectToAction("Index", new { id = inventory.CharacterId });
        }

        private InventoryService CreateInventoryService(InventoryCreate item)
        {
            var ownerId = GetGuid();
            var service = new InventoryService(ownerId, item.CharacterId);
            return service;
        }

        private Guid GetGuid()
        {
            return Guid.Parse(User.Identity.GetUserId());
        }
    }
}