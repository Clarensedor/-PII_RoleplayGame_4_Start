namespace RoleplayGame
{
    public class ExtraLongSword: IAttackItem, IItemWithNotch
    {

        public IGemstone gemstoneNotch {get; set;}
        public bool gemstoneNotchIsUsed {get; set;}
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

        public void AttachGem(IGemstone gem){
            
            this.gemstoneNotch = gem;
            this.AttackValue += gem.value;

        }

        public void DeAttachGem(){
            this.AttackValue -= gemstoneNotch.value;
            this.gemstoneNotch = null;

        }

        
    }
}