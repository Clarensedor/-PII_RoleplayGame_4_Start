namespace RoleplayGame
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class Magic : IAttackItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackValue
        {
            get
            {
                return 80;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefenseValue
        {
            get
            {
                return 30;
            }
        }

        public override string ToString()
        {
            return "Magic";
        }
    }
}