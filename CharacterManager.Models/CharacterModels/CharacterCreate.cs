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

        public Journal Journal { get; set; }
        public Inventory Inventory { get; set; }
    }
}
