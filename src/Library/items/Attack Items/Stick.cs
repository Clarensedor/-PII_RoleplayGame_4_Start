namespace RoleplayGame
{
    public class Stick : IAttackItem
    {
        int id = 5;

        public int AttackValue 
        {
            get
            {
                return 15;
            } 
        }
    }
}