namespace RoleplayGame
{
    /// <summary>
    /// Interfaz para crear elementos.
    /// </summary>
    public interface ICompoundItem : IItem
    {
        IItem item1{get;}
        IItem item2{get;}
    }
}