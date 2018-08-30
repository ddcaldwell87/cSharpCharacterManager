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
                Level = model.Level,
                CharacterName = model.CharacterName,
                CharacterRace = model.CharacterRace,
                CharacterGender = model.CharacterGender,
                CharacterClass = model.CharacterClass,
                Alignment = model.Alignment,
                PersonalityTraits = model.PersonalityTraits,
                Ideals = model.Ideals,
                Bonds = model.Bonds,
                Flaws = model.Flaws,
                HitPoints = model.HitPoints,
                Strength = model.Strength,
                Dexterity = model.Dexterity,
                Constitution = model.Constitution,
                Intelligence = model.Intelligence,
                Wisdom = model.Wisdom,
                Charisma = model.Charisma,
                Acrobatics = model.Acrobatics,
                AnimalHandling = model.AnimalHandling,
                Arcana = model.Arcana,
                Athletics = model.Athletics,
                Deception = model.Deception,
                History = model.History,
                Insight = model.Insight,
                Intimidation = model.Intimidation,
                Investigation = model.Investigation,
                Medicine = model.Medicine,
                Nature = model.Nature,
                Perception = model.Perception,
                Performance = model.Performance,
                Persuasion = model.Persuasion,
                Regligion = model.Regligion,
                SleightOfHand = model.SleightOfHand,
                Stealth = model.Stealth,
                Survival = model.Survival,
                HitDie = model.HitDie,
                ArmorClass = model.ArmorClass,
                Speed = model.Speed,
                Initiative = model.Initiative,
                SavingStr = model.SavingStr,
                SavingDex = model.SavingDex,
                SavingCon = model.SavingCon,
                SavingInt = model.SavingInt,
                SavingWis = model.SavingWis,
                SavingCha = model.SavingCha
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
                        Level = e.Level,
                        CharacterName = e.CharacterName,
                        CharacterRace = e.CharacterRace,
                        CharacterGender = e.CharacterGender,
                        CharacterClass = e.CharacterClass,
                        Alignment = e.Alignment,
                        PersonalityTraits = e.PersonalityTraits,
                        Ideals = e.Ideals,
                        Bonds = e.Bonds,
                        Flaws = e.Flaws,
                        HitPoints = e.HitPoints,
                        Strength = e.Strength,
                        Dexterity = e.Dexterity,
                        Constitution = e.Constitution,
                        Intelligence = e.Intelligence,
                        Wisdom = e.Wisdom,
                        Charisma = e.Charisma,
                        Acrobatics = e.Acrobatics,
                        AnimalHandling = e.AnimalHandling,
                        Arcana = e.Arcana,
                        Athletics = e.Athletics,
                        Deception = e.Deception,
                        History = e.History,
                        Insight = e.Insight,
                        Intimidation = e.Intimidation,
                        Investigation = e.Investigation,
                        Medicine = e.Medicine,
                        Nature = e.Nature,
                        Perception = e.Perception,
                        Performance = e.Performance,
                        Persuasion = e.Persuasion,
                        Regligion = e.Regligion,
                        SleightOfHand = e.SleightOfHand,
                        Stealth = e.Stealth,
                        Survival = e.Survival,
                        HitDie = e.HitDie,
                        ArmorClass = e.ArmorClass,
                        Speed = e.Speed,
                        Initiative = e.Initiative,
                        SavingStr = e.SavingStr,
                        SavingDex = e.SavingDex,
                        SavingCon = e.SavingCon,
                        SavingInt = e.SavingInt,
                        SavingWis = e.SavingWis,
                        SavingCha = e.SavingCha
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
                    Level = entity.Level,
                    CharacterName = entity.CharacterName,
                    CharacterRace = entity.CharacterRace,
                    CharacterGender = entity.CharacterGender,
                    CharacterClass = entity.CharacterClass,
                    Alignment = entity.Alignment,
                    PersonalityTraits = entity.PersonalityTraits,
                    Ideals = entity.Ideals,
                    Bonds = entity.Bonds,
                    Flaws = entity.Flaws,
                    HitPoints = entity.HitPoints,
                    Strength = entity.Strength,
                    Dexterity = entity.Dexterity,
                    Constitution = entity.Constitution,
                    Intelligence = entity.Intelligence,
                    Wisdom = entity.Wisdom,
                    Charisma = entity.Charisma,
                    Acrobatics = entity.Acrobatics,
                    AnimalHandling = entity.AnimalHandling,
                    Arcana = entity.Arcana,
                    Athletics = entity.Athletics,
                    Deception = entity.Deception,
                    History = entity.History,
                    Insight = entity.Insight,
                    Intimidation = entity.Intimidation,
                    Investigation = entity.Investigation,
                    Medicine = entity.Medicine,
                    Nature = entity.Nature,
                    Perception = entity.Perception,
                    Performance = entity.Performance,
                    Persuasion = entity.Persuasion,
                    Regligion = entity.Regligion,
                    SleightOfHand = entity.SleightOfHand,
                    Stealth = entity.Stealth,
                    Survival = entity.Survival,
                    HitDie = entity.HitDie,
                    ArmorClass = entity.ArmorClass,
                    Speed = entity.Speed,
                    Initiative = entity.Initiative,
                    SavingStr = entity.SavingStr,
                    SavingDex = entity.SavingDex,
                    SavingCon = entity.SavingCon,
                    SavingInt = entity.SavingInt,
                    SavingWis = entity.SavingWis,
                    SavingCha = entity.SavingCha
                };
            }
        }

        public bool UpdateCharacter(CharacterEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Characters.Single(e => e.CharacterId == model.CharacterId && e.OwnerId == _ownerId);

                entity.Level = model.Level;
                entity.CharacterName = model.CharacterName;
                entity.CharacterRace = model.CharacterRace;
                entity.CharacterGender = model.CharacterGender;
                entity.CharacterClass = model.CharacterClass;
                entity.Alignment = model.Alignment;
                entity.PersonalityTraits = model.PersonalityTraits;
                entity.Ideals = model.Ideals;
                entity.Bonds = model.Bonds;
                entity.Flaws = model.Flaws;
                entity.HitPoints = model.HitPoints;
                entity.Strength = model.Strength;
                entity.Dexterity = model.Dexterity;
                entity.Constitution = model.Constitution;
                entity.Intelligence = model.Intelligence;
                entity.Wisdom = model.Wisdom;
                entity.Charisma = model.Charisma;
                entity.Acrobatics = model.Acrobatics;
                entity.AnimalHandling = model.AnimalHandling;
                entity.Arcana = model.Arcana;
                entity.Athletics = model.Athletics;
                entity.Deception = model.Deception;
                entity.History = model.History;
                entity.Insight = model.Insight;
                entity.Intimidation = model.Intimidation;
                entity.Investigation = model.Investigation;
                entity.Medicine = model.Medicine;
                entity.Nature = model.Nature;
                entity.Perception = model.Perception;
                entity.Performance = model.Performance;
                entity.Persuasion = model.Persuasion;
                entity.Regligion = model.Regligion;
                entity.SleightOfHand = model.SleightOfHand;
                entity.Stealth = model.Stealth;
                entity.Survival = model.Survival;
                entity.HitDie = model.HitDie;
                entity.ArmorClass = model.ArmorClass;
                entity.Speed = model.Speed;
                entity.Initiative = model.Initiative;
                entity.SavingStr = model.SavingStr;
                entity.SavingDex = model.SavingDex;
                entity.SavingCon = model.SavingCon;
                entity.SavingInt = model.SavingInt;
                entity.SavingWis = model.SavingWis;
                entity.SavingCha = model.SavingCha;

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
