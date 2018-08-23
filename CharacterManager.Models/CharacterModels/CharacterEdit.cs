using CharacterManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Models.CharacterModels
{
    public class CharacterEdit
    {
        public int CharacterId { get; set; }

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

        [Display(Name = "Personality Traits")]
        public string PersonalityTraits { get; set; }

        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
