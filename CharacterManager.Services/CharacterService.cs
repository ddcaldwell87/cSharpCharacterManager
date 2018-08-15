using CharacterManager.Data;
using CharacterManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Services
{
    public class CharacterService
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
                CharacterClass = model.CharacterClass
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
