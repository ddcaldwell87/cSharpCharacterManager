using CharacterManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Models.CharacterModels
{
    public class CharacterCreate
    {
        [Required]
        [Display(Name = "Name")]
        public string CharacterName { get; set; }

        [Required]
        [Display(Name = "Race")]
        public Race CharacterRace { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public Gender CharacterGender { get; set; }

        [Required]
        [Display(Name = "Class")]
        public Class CharacterClass { get; set; }

        [Required]
        public Alignment Alignment { get; set; }

        [Required]
        [Display(Name = "Hit Points")]
        public int HitPoints { get; set; }

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

        public Journal Journal { get; set; }
        public Inventory Inventory { get; set; }
    }
}
