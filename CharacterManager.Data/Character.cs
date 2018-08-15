using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Data
{
    public enum Race
    {
        Human = 1, Elf, Dwarf, Halfling, Orc, Gnome
    }

    public enum Gender
    {
        Male = 1, Female
    }

    public enum Class
    {
        Barbarian = 1, Bard, Cleric, Druid, Fighter, Monk, Paladin, Ranger, Rogue, Sorcerer, Warlock, Wizard
    }

    public class Character
    {
        [Key]
        public int CharacterId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string CharacterName { get; set; }

        [Required]
        public Race Race { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public Class Class { get; set; }
    }
}
