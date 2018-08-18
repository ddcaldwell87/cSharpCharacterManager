using CharacterManager.Contracts;
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
            throw new NotImplementedException();
        }

        public IEnumerable<InventoryListItem> GetInventory()
        {
            throw new NotImplementedException();
        }

        public InventoryItemDetail GetInventoryItemById(int itemId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateInventoryItem(InventoryEdit item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteInventory(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
