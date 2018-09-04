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
        public int Level { get; set; }

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

        public int? ArmorClass { get; set; }
        public int? Initiative { get; set; }
        public int? Speed { get; set; }
        public string HitDie { get; set; }

        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }

        [Required]
        public int Strength { get; set; }

        [Required]
        public int Dexterity { get; set; }

        [Required]
        public int Constitution { get; set; }

        [Required]
        public int Intelligence { get; set; }

        [Required]
        public int Wisdom { get; set; }
        
        [Required]
        public int Charisma { get; set; }

        public int? SavingStr { get; set; }
        public int? SavingDex { get; set; }
        public int? SavingCon { get; set; }
        public int? SavingInt { get; set; }
        public int? SavingWis { get; set; }
        public int? SavingCha { get; set; }

        public int? Acrobatics { get; set; }
        public int? AnimalHandling { get; set; }
        public int? Arcana { get; set; }
        public int? Athletics { get; set; }
        public int? Deception { get; set; }
        public int? History { get; set; }
        public int? Insight { get; set; }
        public int? Intimidation { get; set; }
        public int? Investigation { get; set; }
        public int? Medicine { get; set; }
        public int? Nature { get; set; }
        public int? Perception { get; set; }
        public int? Performance { get; set; }
        public int? Persuasion { get; set; }
        public int? Religion { get; set; }
        public int? SleightOfHand { get; set; }
        public int? Stealth { get; set; }
        public int? Survival { get; set; }
    }
}
