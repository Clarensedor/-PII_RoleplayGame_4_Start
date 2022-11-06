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

<<<<<<< Updated upstream
       }


      // tenemos que simular todo lo que hacemos en program aca 
       public void Run(){


        //Con esto generamos numeros aleatorios para seleccionar id de ITEMS:

          Random rnd = new Random();
          int aleatorio = rnd.Next(1, 15 + 1);
           
         // characters[aleatorio].ReceiveAttack(characters[1]);
          
=======
        pintonio.AddItem(random4);
        pintonio.AddItem(random4);

        // nos falta aca ver el que sobrevive de cada pelea
        // USAR LA CLASE ENCOUNTER PARA VER LA PELEA ENTRE DOS PERSONAJES
        // USAR EXCHANGE ENCOUNTER PARA QUE EQUIPEN LOS ITEMS RANDOM QUE HEMOS GENERADOS

      }

       public void Run(Encounters.EncounterType type,Character martincito, Character pintonio, Character juancito, Character antoncito)
       {
         // Batalla entre Personaje 1 y Personaje 2:

           Encounters.EncounterFactory.GetEncounter (Encounters.EncounterType.Attack ,martincito,pintonio);

        // Ver quien gana de los dos:



        //Se cura totalmente: ///necesito hacer el metodo para curarse en character

       // Character supermartincito = martincito.Health 


         // Batalla entre Personaje 1 y Personaje 2:

           Encounters.EncounterFactory.GetEncounter (Encounters.EncounterType.Attack ,juancito,antoncito);
>>>>>>> Stashed changes

        }

    }
}

