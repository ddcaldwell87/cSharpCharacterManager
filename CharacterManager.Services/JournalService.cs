using CharacterManager.Contracts;
using CharacterManager.Data;
using CharacterManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Services
{
    public class JournalService : IJournalService
    {
        private readonly Guid _ownerId;
        private readonly int _characterId;

        public JournalService(){}

        public JournalService(Guid ownerId, int characterId)
        {
            _ownerId = ownerId;
            _characterId = characterId;
        }

        public bool CreateJournalEntry(JournalCreate model)
        {
            var entity = new Journal
            {
                OwnerId = _ownerId,
                CharacterId = _characterId,
                Title = model.Title,
                Content = model.Content,
                CreatedUtc = DateTimeOffset.Now
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Journals.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<JournalListItem> GetJournals()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Journals.Where(e => e.OwnerId == _ownerId && e.CharacterId == _characterId)
                    .Select(e => new JournalListItem
                    {
                        JournalId = e.JournalId,
                        CharacterId = e.CharacterId,
                        Title = e.Title,
                        Content = e.Content,
                        CreatedUtc = e.CreatedUtc
                    });
                return query.ToArray();
            }
        }

        public bool DeleteJournalEntry(int journalId)
        {
            throw new NotImplementedException();
        }

        public JournalDetail GetJournalById(int journalId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateJournalEntry(JournalEdit model)
        {
            throw new NotImplementedException();
        }
    }
}
