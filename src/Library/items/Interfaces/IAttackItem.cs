namespace RoleplayGame
{
    /// <summary>
    /// Interfaz que permite crear elementos de ataque.
    /// </summary>
    public interface IAttackItem: IItem
    {
        int AttackValue{ get; }
    }
}