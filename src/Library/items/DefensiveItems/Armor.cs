using System.Collections.Generic;

namespace RoleplayGame
{
   
    
    public class Armor: IDefenseItem
    {
         int id = 8;
        public int DefenseValue
        {
            get
            {
                return 25;
            }
        }
    }
}