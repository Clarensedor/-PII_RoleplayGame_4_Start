namespace RoleplayGame
{
    public class Axe: IAttackItem
    {
        int id = 1;

        public int AttackValue 
        {
            get
            {
                return 25;
            } 
        }
    }
}