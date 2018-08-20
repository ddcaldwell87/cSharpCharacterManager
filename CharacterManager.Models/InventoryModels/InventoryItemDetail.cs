using System;
using System.ComponentModel.DataAnnotations;

namespace CharacterManager.Contracts
{
    public class InventoryItemDetail
    {
        public int InventoryId { get; set; }
        public int CharacterId { get; set; }
        public Guid OwnerId { get; set; }

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