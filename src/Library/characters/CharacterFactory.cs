namespace RoleplayGame.Characters
{
    /// <summary>
    /// Tipos de personajes
    /// </summary>
    public enum CharacterType
    {
        Elf = 1,
        Wizard = 2,
        Human = 3,
        Troll = 4,
        Necromancer = 5
    }

    /// <summary>
    /// Crea objetos de tipo Personaje
    /// </summary>
    public class CharacterFactory
    {
        /// <summary>
        /// Crea un personaje dado un tipo de personaje y un nombre
        /// </summary>
        public static Character GetCharacter(CharacterType type, string name)
        {
            switch (type)
            {
                case CharacterType.Elf: return new Elf(name);
                case CharacterType.Wizard: return new Wizard(name);
                case CharacterType.Human: return new Human(name);
                case CharacterType.Troll: return new Troll(name);
                case CharacterType.Necromancer: return new Necromancer(name);

                default: throw new System.Exception($"Invalid character {type}");
            }
        }
    }
}