using CharacterManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Models
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

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
