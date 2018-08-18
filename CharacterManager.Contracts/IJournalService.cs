using CharacterManager.Models.JournalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Contracts
{
    public interface IJournalService
    {
        bool CreateJournalEntry(JournalCreate model);
        IEnumerable<JournalListItem> GetJournals();
        JournalDetail GetJournalById(int journalId);
        bool UpdateJournalEntry(JournalEdit model);
        bool DeleteJournalEntry(int journalId);
    }
}
