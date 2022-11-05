namespace RoleplayGame
{
    public class Stone: IAttackItem
    {
        int id = 6;
        
        public int AttackValue 
        {
            get
            {
                return 5;
            } 
        }
    }
}
