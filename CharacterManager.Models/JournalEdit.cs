using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Models
{
    public class JournalEdit
    {
        public int JournalId { get; set; }
        public int CharacterId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
