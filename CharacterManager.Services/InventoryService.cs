using CharacterManager.Contracts;
using CharacterManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly Guid _ownerId;
        private readonly int _characterId;

        public InventoryService(Guid ownerId)
        {
            _ownerId = ownerId;
        }

        public InventoryService(Guid ownerId, int characterId)
        {
            _ownerId = ownerId;
            _characterId = characterId;
        }

        public bool InventoryItemCreate(InventoryCreate item)
        {
            var entity = new Inventory
            {
                OwnerId = _ownerId,
                InventoryId = item.InventoryId,
                CharacterId = item.CharacterId,
                ItemName = item.ItemName,
                ItemQuantity = item.ItemQuantity,
                ItemType = item.ItemType
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Inventories.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<InventoryListItem> GetInventory()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Inventories.Where(e => e.OwnerId == _ownerId && e.CharacterId == _characterId)
                    .Select(e => new InventoryListItem
                    {
                        InventoryId = e.InventoryId,
                        CharacterId = e.CharacterId,
                        ItemName = e.ItemName,
                        ItemQuantity = e.ItemQuantity,
                        ItemType = e.ItemType
                    });
                return query.ToArray();
            }
        }

        public InventoryItemDetail GetInventoryItemById(int inventoryId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Inventories.Single(e => e.OwnerId == _ownerId && e.InventoryId == inventoryId);
                return new InventoryItemDetail
                {
                    InventoryId = entity.InventoryId,
                    CharacterId = entity.CharacterId,
                    ItemName = entity.ItemName,
                    ItemQuantity = entity.ItemQuantity,
                    ItemType = entity.ItemType
                };
            }
        }

        public bool UpdateInventoryItem(InventoryEdit item)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Inventories.Single(e => e.OwnerId == _ownerId && e.InventoryId == item.InventoryId);

                entity.ItemName = item.ItemName;
                entity.ItemQuantity = item.ItemQuantity;
                entity.ItemType = item.ItemType;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteInventory(int itemId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Inventories.Single(e => e.OwnerId == _ownerId && e.InventoryId == itemId);

                ctx.Inventories.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
