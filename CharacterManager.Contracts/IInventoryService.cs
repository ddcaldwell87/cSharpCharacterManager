using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Contracts
{
    public interface IInventoryService
    {
        bool InventoryItemCreate(InventoryCreate item);
        IEnumerable<InventoryListItem> GetInventory();
        InventoryItemDetail GetInventoryItemById(int itemId);
        bool UpdateInventoryItem(InventoryEdit item);
        bool DeleteInventory(int itemId);
    }
}
