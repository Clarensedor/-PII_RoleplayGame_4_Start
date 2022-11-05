namespace RoleplayGame
{
    /// <summary>
    /// Interfaz que permite crear elementos de ataque.
    /// </summary>
    public interface IItemWithNotch: IItem
    {
        public bool gemstoneNotchIsUsed {get;set;}
        public IGemstone gemNotch {get; set;}
        void AttachGem(IGemstone gem);
        void DeAttachGem();
        
        }

    }
