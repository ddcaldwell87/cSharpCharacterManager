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
        Aarakocra = 1, Aasimar, Bugbear, Centaur, Changeling, Dragonborn, Dwarf, Elf, Feral_Tiefling, Firbolg, Genasi, Gith, Gnome, Goblin, Goliath, HalfElf, Halfling, HalfOrc, Hobgoblin, Human, Kalashtar, Kenku, Kobold, Lizardfolk, Minotaur, Orc, Shifter, Tabaxi, Tiefling, Tortle, Triton, Warforged, YuanTi_Pureblood
    }

    public enum Gender
    {
        Male = 1,
        Female,
        Other
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
        public Race CharacterRace { get; set; }

        [Required]
        public Gender CharacterGender { get; set; }

        [Required]
        public Class CharacterClass { get; set; }
    }
}
