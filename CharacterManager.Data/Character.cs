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
        [Display(Name = "Aarakocra")] Aarakocra = 1,
        [Display(Name = "Aasimar")] Aasimar,
        [Display(Name = "Bugbear")] Bugbear,
        [Display(Name = "Centaur")] Centaur,
        [Display(Name = "Changeling")] Changeling,
        [Display(Name = "Dragonborn")] Dragonborn,
        [Display(Name = "Dwarf")] Dwarf,
        [Display(Name = "Elf")] Elf,
        [Display(Name = "Feral Tiefling")] Feral_Tiefling,
        [Display(Name = "Firbolg")] Firbolg,
        [Display(Name = "Genasi")] Genasi,
        [Display(Name = "Gith")] Gith,
        [Display(Name = "Gnome")] Gnome,
        [Display(Name = "Goblin")] Goblin,
        [Display(Name = "Goliath")] Goliath,
        [Display(Name = "Half Elf")] HalfElf,
        [Display(Name = "Halfling")] Halfling,
        [Display(Name = "Half Orc")] HalfOrc,
        [Display(Name = "Hobgoblin")] Hobgoblin,
        [Display(Name = "Human")] Human,
        [Display(Name = "Kalashtar")] Kalashtar,
        [Display(Name = "Kenku")] Kenku,
        [Display(Name = "Kobold")] Kobold,
        [Display(Name = "Lizardfolk")] Lizardfolk,
        [Display(Name = "Minotaur")] Minotaur,
        [Display(Name = "Orc")] Orc,
        [Display(Name = "Shifter")] Shifter,
        [Display(Name = "Tabaxi")] Tabaxi,
        [Display(Name = "Tiefling")] Tiefling,
        [Display(Name = "Tortle")] Tortle,
        [Display(Name = "Triton")] Triton,
        [Display(Name = "Warforged")] Warforged,
        [Display(Name = "Yuan-ti Pureblood")] YuanTi_Pureblood
    }

    public enum Gender
    {
        Male = 1,
        Female,
        Other
    }

    public enum Class
    {
        Barbarian = 1,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Wizard
    }

    public enum Alignment
    {
        [Display(Name = "Lawful Good")] LawfulGood = 1,
        [Display(Name = "Lawful Neutral")] LawfulNeutral,
        [Display(Name = "Lawful Evil")] LawfulEvil,
        [Display(Name = "Neutral Good")] NeutralGood,
        [Display(Name = "True Neutral")] TrueNeutral,
        [Display(Name = "Neutral Evil")] NeutralEvil,
        [Display(Name = "Chaotic Good")] ChaoticGood,
        [Display(Name = "Chaotic Neutral")] ChaoticNeutral,
        [Display(Name = "Chaotic Evil")] ChaoticEvil
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
