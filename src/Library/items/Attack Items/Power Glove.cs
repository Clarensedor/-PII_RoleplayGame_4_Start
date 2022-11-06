namespace RoleplayGame
{
    public class PowerGlove: IAttackItem, IItemWithNotch
    {

        public IGemstone gemNotch {get; set;}
        public bool gemstoneNotchIsUsed {get;set;}
        public int AttackValue 
        {
            get
            {
                return 60;
            } 
            set{
                this.AttackValue = value;
            }
        }

        public int id 
        {
            get
            {
                return 5;
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