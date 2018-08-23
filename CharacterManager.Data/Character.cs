using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Data
{
    public enum Race
    {
        Aarakocra = 1, Aasimar, Bugbear, Centaur, Changeling, Dragonborn, Dwarf, Elf, [Display(Name = "Feral Tiefling")] Feral_Tiefling, Firbolg, Genasi, Gith, Gnome, Goblin, Goliath, [Display(Name = "Half Elf")] HalfElf, Halfling, [Display(Name = "Half Orc")] HalfOrc, Hobgoblin, Human, Kalashtar, Kenku, Kobold, Lizardfolk, Minotaur, Orc, Shifter, Tabaxi, Tiefling, Tortle, Triton, Warforged, [Display(Name = "Yuan-ti Pureblood")] YuanTi_Pureblood
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

    public enum Alignment
    {
        [Display(Name = "Lawful Good")] LawfulGood = 1, [Display(Name = "Lawful Neutral")] LawfulNeutral, [Display(Name = "Lawful Evil")] LawfulEvil, [Display(Name = "Neutral Good")] NeutralGood, [Display(Name = "True Neutral")] TrueNeutral, [Display(Name = "Neutral Evil")] NeutralEvil, [Display(Name = "Chaotic Good")] ChaoticGood, [Display(Name = "Chaotic Neutral")] ChaoticNeutral, [Display(Name = "Chaotic Evil")] ChaoticEvil
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

        [Required]
        public Alignment Alignment { get; set; }

        [Required]
        public int HitPoints { get; set; }

        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }

    }
}
