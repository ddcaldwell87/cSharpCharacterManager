using System.ComponentModel.DataAnnotations;

namespace CharacterManager.Contracts
{
    public class InventoryListItem
    {
        public int InventoryId { get; set; }
        public int CharacterId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string ItemName { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int ItemQuantity { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string ItemType { get; set; }
    }
}