using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Data
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        public int CharacterId { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public int ItemQuantity { get; set; }

        [Required]
        public string ItemType { get; set; }

        public Character Character { get; set; }
    }
}
