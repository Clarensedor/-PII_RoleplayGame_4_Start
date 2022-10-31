using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook: IMagicalAttackItem, IMagicalDefenseItem
    {
        private List<ISpell> spells = new List<ISpell>();
        
        public SpellsBook(string name)
        {
            
            this.spells= new List<ISpell>();

        }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (ISpell spell in this.spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (ISpell spell in this.spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }

        public void AddSpells(ISpell spell)
        {
            this.spells.Add(spell);
        }


    }
}