using CharacterManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Models.CharacterModels
{
    public class CharacterDetail
    {
        public int CharacterId { get; set; }

        [Required]
        public int Level { get; set; }

        [Display(Name = "Name")]
        public string CharacterName { get; set; }

        [Display(Name = "Race")]
        public Race CharacterRace { get; set; }

        [Display(Name = "Gender")]
        public Gender CharacterGender { get; set; }

        [Display(Name = "Class")]
        public Class CharacterClass { get; set; }

        [Required]
        public Alignment Alignment { get; set; }

        [Required]
        [Display(Name = "Hit Points")]
        public int HitPoints { get; set; }

        [Display(Name = "Armor Class")]
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        [Display(Name = "Hit Die")]
        public string HitDie { get; set; }

        [Display(Name = "Personality Traits")]
        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        [Display(Name = "Strength")]
        public int SavingStr { get; set; }
        [Display(Name = "Dexterity")]
        public int SavingDex { get; set; }
        [Display(Name = "Constitiution")]
        public int SavingCon { get; set; }
        [Display(Name = "Intelligence")]
        public int SavingInt { get; set; }
        [Display(Name = "Wisdom")]
        public int SavingWis { get; set; }
        [Display(Name = "Charisma")]
        public int SavingCha { get; set; }

        public int Acrobatics { get; set; }
        [Display(Name = "Animal Handling")]
        public int AnimalHandling { get; set; }
        public int Arcana { get; set; }
        public int Athletics { get; set; }
        public int Deception { get; set; }
        public int History { get; set; }
        public int Insight { get; set; }
        public int Intimidation { get; set; }
        public int Investigation { get; set; }
        public int Medicine { get; set; }
        public int Nature { get; set; }
        public int Perception { get; set; }
        public int Performance { get; set; }
        public int Persuasion { get; set; }
        public int Religion { get; set; }
        [Display(Name = "Sleight Of Hand")]
        public int SleightOfHand { get; set; }
        public int Stealth { get; set; }
        public int Survival { get; set; }

        public virtual ICollection<Journal> Journals { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
