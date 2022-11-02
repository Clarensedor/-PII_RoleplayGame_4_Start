namespace RoleplayGame
{
    /// <summary>
    /// Interfaz que permite crear elementos de defensa.
    /// </summary>
    public interface IDefenseItem: IItem
    {
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value>Poder de defensa</value>
        int DefenseValue{ get; }
    }
}