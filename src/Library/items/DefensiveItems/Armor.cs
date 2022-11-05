using System.Collections.Generic;

namespace RoleplayGame
{
   
    
    public class Armor: IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 25;
            }
        }

        public int id
        {
            get
            {
                return 8;
            }
        }
    }
}