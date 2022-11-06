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
        var antoncito = CharacterFactory.GetCharacter(CharacterType.Necromancer, "antoncito");

        
        //crea las instancias de items del items factory
        var stick = ItemFactory.GetItem(ItemType.Robes);
       
  
        //agrego los character a la lista
        characters.Add(martinsito);
        characters.Add(pintonio);
        characters.Add(juancito);
        characters.Add(antoncito);

         //Random random = new Random();
         //int numeroAleatorio = random.Next(0, );
         


          //Con esto generamos numeros aleatorios para seleccionar id de ITEMS:
          Random rnd = new Random();

   
         int randIndex = rnd.Next(items.Count);

        IItem random = items[randIndex];
 
         martinsito.AddItem(random);
         martinsito.AddItem(random);

       }


      // tenemos que simular todo lo que hacemos en program aca 
       public void Run(){
           
         // characters[aleatorio].ReceiveAttack(characters[1]);
          

        }

    }
}

