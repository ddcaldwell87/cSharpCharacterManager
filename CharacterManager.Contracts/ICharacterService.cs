using CharacterManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Contracts
{
    public interface ICharacterService
    {
        bool CharacterCreate(CharacterCreate model);
        IEnumerable<CharacterListItem> GetCharacters();
        CharacterDetail GetCharacterById(int characterId);
        bool UpdateCharacter(CharacterEdit model);
        bool DeleteCharacater(int characterId);
    }
}
