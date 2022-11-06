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
        var martinsito = CharacterFactory.GetCharacter(CharacterType.Elf, "martinsito"); // Personaje 1
        var pintonio = CharacterFactory.GetCharacter(CharacterType.Human, "Pintonio"); // Personaje 2 
        var juancito = CharacterFactory.GetCharacter(CharacterType.Wizard, "Juancito"); // Personaje 3
        var antoncito = CharacterFactory.GetCharacter(CharacterType.Necromancer, "antoncito"); // Personaje 4

        
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

        // Aca se crea un numero segun el indice de la lista Items, que van desde el 1 al 15
        int randIndex = rnd.Next(items.Count);
        int randIndex2 = rnd.Next(items.Count);
        int randIndex3 = rnd.Next(items.Count);
        int randIndex4 = rnd.Next(items.Count);

        // Aca lo que se hace, es seleccionar un item segun el randIndex creado anteriormente

        IItem random = items[randIndex];
        IItem random2 = items[randIndex2];
        IItem random3 = items[randIndex3];
        IItem random4 = items[randIndex4];

        // Aca se equipa un objeto de la lista de items segun lo random

        martinsito.AddItem(random);
        martinsito.AddItem(random);

        antoncito.AddItem(random2);
        antoncito.AddItem(random2);

        juancito.AddItem(random3);
        juancito.AddItem(random3);

        pintonio.AddItem(random4);
        pintonio.AddItem(random4);



       }

       public void Run(){
           
         // characters[aleatorio].ReceiveAttack(characters[1]);
          

        }

    }
}

