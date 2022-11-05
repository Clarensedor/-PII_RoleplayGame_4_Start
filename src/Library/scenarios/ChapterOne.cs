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
        characters.Add(martinsito);
        characters.Add(pintonio);
        characters.Add(juancito);


         Random random = new Random();
         //int numeroAleatorio = random.Next(0, );
         //Martinsito.AddItem(numeroAletorio);



       }

       public void Run(){
        martinsito

        }

    }


}

