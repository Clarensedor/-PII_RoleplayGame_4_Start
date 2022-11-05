namespace RoleplayGame
{
    public class PrisonSpear: IAttackItem, ICompoundItem
    {

        public  IItem item1 {get;}
        public IItem item2{get;}

        public int AttackValue 
        {
            get
            {
                return 32;
            } 
        }

        public int id 
        {
            get
            {
                return 4;
            } 
        }

        public PrisonSpear (IItem item1,IItem item2)
        {
            this.item1 = item1;
            this.item2 = item2;

        }
    }
}