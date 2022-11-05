namespace RoleplayGame
{
    public class ExtraLongSword: IAttackItem, IItemWithNotch
    {

        public IGemstone gemNotch {get; set;}
        public bool gemstoneNotchIsUsed {get;set;}
        public int AttackValue 
        {
            get
            {
                return 50;
            } 
            set{
                this.AttackValue = value;
            }
        }


        public int id 
        {
            get
            {
                return 3;
            } 
        }
        public void AttachGem(IGemstone gem){

            this.gemNotch = gem;
            this.AttackValue += gem.value;
            this.gemstoneNotchIsUsed = true;

        }

        public void DeAttachGem(){
            this.AttackValue -= gemNotch.value;
            this.gemstoneNotchIsUsed = false;

        }

        
    }
}