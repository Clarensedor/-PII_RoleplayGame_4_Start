using System.Collections.Generic;
using RoleplayGame;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Elfo
    /// </summary>
    public class Necromancer : Character
    {
        public Necromancer(string name)
            : base(name)
        {
            this.Health = 50;
           // this.AddItem();
        }
    }
}