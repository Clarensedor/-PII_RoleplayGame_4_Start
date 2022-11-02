using System.Collections.Generic;
using RoleplayGame;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Elfo
    /// </summary>
    public class Human : Character
    {
        public Human(string name)
            : base(name)
        {
            this.Health = 75;
           // this.AddItem();
        }
    }
}