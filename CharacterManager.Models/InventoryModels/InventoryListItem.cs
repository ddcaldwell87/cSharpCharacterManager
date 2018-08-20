using System.ComponentModel.DataAnnotations;

namespace CharacterManager.Contracts
{
    public class InventoryListItem
    {
        public int InventoryId { get; set; }
        public int CharacterId { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public int ItemQuantity { get; set; }

        [Required]
        public string ItemType { get; set; }
    }
}