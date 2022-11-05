namespace RoleplayGame
{
    public class Bow: IAttackItem
    {
        public int AttackValue 
        {
            get
            {
                return 15;
            } 
        }
        
        public int id 
        {
            get
            {
                return 2;
            } 
        }
    }
}