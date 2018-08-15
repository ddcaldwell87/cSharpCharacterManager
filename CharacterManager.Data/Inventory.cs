using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Data
{
    class Inventory
    {
        [Key]
        public int InventoryID { get; set; }

        public int CharacterID { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public int ItemQuantity { get; set; }

        [Required]
        public string ItemType { get; set; }

        public virtual Character Character { get; set; }
    }
}
