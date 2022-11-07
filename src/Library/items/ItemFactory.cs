namespace RoleplayGame
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,

        Axe = 3,
        Bow = 4,
        ExtraLongSword = 5,
        PowerGlove = 6,
        Shiv = 7,
        Stone = 8,
        Sword = 9,
        
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.Axe: return new Axe();
                case ItemType.Stone: return new Stone();
                case ItemType.Bow: return new Bow();
                case ItemType.Shiv: return new Shiv();
                case ItemType.ExtraLongSword: return new ExtraLongSword();
                case ItemType.PowerGlove: return new PowerGlove();
                

                default: return null;
            }
        }
    }
}