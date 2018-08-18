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

        public JournalService(Guid ownerId)
        {
            _ownerId = ownerId;
        }

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

        public JournalDetail GetJournalById(int journalId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Journals.Single(e => e.OwnerId == _ownerId && e.JournalId == journalId);
                return new JournalDetail
                {
                    JournalId = entity.JournalId,
                    CharacterId = entity.CharacterId,
                    Title = entity.Title,
                    Content = entity.Content,
                    CreatedUtc = entity.CreatedUtc,
                    ModifiedUtc = entity.ModifiedUtc
                };
            }
        }

        public bool UpdateJournalEntry(JournalEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Journals.Single(e => e.JournalId == model.JournalId && e.OwnerId == _ownerId);

                entity.Title = model.Title;
                entity.Content = model.Content;
                entity.ModifiedUtc = DateTimeOffset.Now;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteJournalEntry(int journalId)
        {
            throw new NotImplementedException();
        }
    }
}
