using CharacterManager.Contracts;
using CharacterManager.Data;
using CharacterManager.Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly Guid _ownerId;

        public CharacterService(Guid ownerId)
        {
            _ownerId = ownerId;
        }

        public bool CharacterCreate(CharacterCreate model)
        {
            var entity = new Character()
            {
                OwnerId = _ownerId,
                CharacterName = model.CharacterName,
                CharacterRace = model.CharacterRace,
                CharacterGender = model.CharacterGender,
                CharacterClass = model.CharacterClass,
                Alignment = model.Alignment,
                PersonalityTraits = model.PersonalityTraits,
                Ideals = model.Ideals,
                Bonds = model.Bonds,
                Flaws = model.Flaws,
                HitPoints = model.HitPoints
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CharacterListItem> GetCharacters()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Characters.Where(e => e.OwnerId == _ownerId)
                    .Select(e => new CharacterListItem
                    {
                        CharacterId = e.CharacterId,
                        CharacterName = e.CharacterName,
                        CharacterRace = e.CharacterRace,
                        CharacterGender = e.CharacterGender,
                        CharacterClass = e.CharacterClass,
                        Alignment = e.Alignment,
                        PersonalityTraits = e.PersonalityTraits,
                        Ideals = e.Ideals,
                        Bonds = e.Bonds,
                        Flaws = e.Flaws,
                        HitPoints = e.HitPoints
                    });
                return query.ToArray();
            }
        }

        public CharacterDetail GetCharacterById(int characterId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Characters.Single(e => e.CharacterId == characterId && e.OwnerId == _ownerId);
                return new CharacterDetail
                {
                    CharacterId = entity.CharacterId,
                    CharacterName = entity.CharacterName,
                    CharacterRace = entity.CharacterRace,
                    CharacterGender = entity.CharacterGender,
                    CharacterClass = entity.CharacterClass,
                    Alignment = entity.Alignment,
                    PersonalityTraits = entity.PersonalityTraits,
                    Ideals = entity.Ideals,
                    Bonds = entity.Bonds,
                    Flaws = entity.Flaws,
                    HitPoints = entity.HitPoints
                };
            }
        }

        public bool UpdateCharacter(CharacterEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Characters.Single(e => e.CharacterId == model.CharacterId && e.OwnerId == _ownerId);

                entity.CharacterName = model.CharacterName;
                entity.CharacterRace = model.CharacterRace;
                entity.CharacterGender = model.CharacterGender;
                entity.CharacterClass = model.CharacterClass;
                entity.Alignment = model.Alignment,
                entity.PersonalityTraits = model.PersonalityTraits,
                entity.Ideals = model.Ideals;
                entity.Bonds = model.Bonds;
                entity.Flaws = model.Flaws;
                entity.HitPoints = model.HitPoints;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCharacater(int characterId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Characters.Single(e => e.CharacterId == characterId && e.OwnerId == _ownerId);

                ctx.Characters.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
