namespace RoleplayGame
{
    /// <summary>
    /// Túnica. Permite defenderse levemente.
    /// </summary>
    public class Robes : IDefenseItem
    {
         int id = 11;
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefenseValue
        {
            get
            {
                return 2;
            }
        }

        public override string ToString()
        {
            return "Robes";
        }
    }
}