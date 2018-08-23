﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Models.JournalModels
{
    public class JournalEdit
    {
        public int JournalId { get; set; }
        public int CharacterId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
