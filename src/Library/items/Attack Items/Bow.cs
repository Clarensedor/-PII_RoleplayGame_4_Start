namespace RoleplayGame
{
    public class Bow: IAttackItem
    {
        int id = 2;

        public int AttackValue 
        {
            get
            {
                return 15;
            } 
        }
    }
}