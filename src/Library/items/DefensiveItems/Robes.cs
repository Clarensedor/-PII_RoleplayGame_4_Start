namespace RoleplayGame
{
    /// <summary>
    /// Túnica. Permite defenderse levemente.
    /// </summary>
    public class Robes : IDefenseItem
    {
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

        public int id
        {
            get
            {
                return 11;
            }
        }


        public override string ToString()
        {
            return "Robes";
        }
    }
}