using System;
using System.Collections.Generic;
using RoleplayGame.Characters;

namespace RoleplayGame.Scenarios
{
    public class ChapterOne : IScenario { 

      public List<Character> characters;
      public List<IItem> items;




       public void Setup(){


        //creamos las tres instancias de characters del character factory
        var martinsito = CharacterFactory.GetCharacter(CharacterType.Elf, "martinsito");
        var pintonio = CharacterFactory.GetCharacter(CharacterType.Human, "Pintonio");
        var juancito = CharacterFactory.GetCharacter(CharacterType.Wizard, "Juancito");
        
        //crea las instancias de items del items factory
        var stick = ItemFactory.GetItem(ItemType.Robes);
       
  
        //agrego los character a la lista
        characters.Add(martinsito);
        characters.Add(pintonio);
        characters.Add(juancito);


         //Random random = new Random();
         //int numeroAleatorio = random.Next(0, );
         //Martinsito.AddItem(numeroAletorio);



       }

       public void Run(){
          characters[0].ReceiveAttack(characters[1]);
          

        }

    }


}

