using System.Collections.Generic;
using RoleplayGame;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Elfo
    /// </summary>
    public class Troll : Character
    {
        public Troll(string name)
            : base(name)
        {
            this.Health = 200;
           // this.AddItem();
        }
    }
}