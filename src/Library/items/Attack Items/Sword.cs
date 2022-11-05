namespace RoleplayGame
{
    public class Sword: IAttackItem
    {
        int id = 7;
        
        public int AttackValue 
        {
            get
            {
                return 20;
            } 
        }
    }
}