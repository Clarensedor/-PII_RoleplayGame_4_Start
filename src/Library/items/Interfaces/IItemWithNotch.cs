namespace RoleplayGame
{
    /// <summary>
    /// Interfaz que permite crear elementos de ataque.
    /// </summary>
    public interface IItemWithNotch: IItem
    {
        public bool gemstoneNotchIsUsed {get; set;}
        public IGemstone gemstoneNotch {get; set;}
        void AttachGem(IGemstone gem);
        void DeAttachGem();
        
        }

    }
