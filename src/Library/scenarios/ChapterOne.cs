using System;
using System.Collections.Generic;
using RoleplayGame.Characters;
using RoleplayGame.Encounters;

namespace RoleplayGame.Scenarios
{
    public class ChapterOne : IScenario { 

      public List<Character> characters;
      public List<IItem> items;

      public List<AttackEncounter> battles;

       public void Setup(){
        characters = new List<Character>();
         items = new List<IItem>();
          battles = new List<AttackEncounter>();


        //creamos las tres instancias de characters del character factory
        var martinsito = CharacterFactory.GetCharacter(CharacterType.Elf, "martinsito"); // Personaje 1
        var pintonio = CharacterFactory.GetCharacter(CharacterType.Human, "Pintonio"); // Personaje 2 
        var juancito = CharacterFactory.GetCharacter(CharacterType.Wizard, "Juancito"); // Personaje 3
        var antoncito = CharacterFactory.GetCharacter(CharacterType.Necromancer, "antoncito"); // Personaje 4

        
        //crea las instancias de items del items factory

        
        var axe = ItemFactory.GetItem(ItemType.Axe);
        var bow = ItemFactory.GetItem(ItemType.Bow);
        var els = ItemFactory.GetItem(ItemType.ExtraLongSword);
        var pg = ItemFactory.GetItem(ItemType.PowerGlove);
        var shiv = ItemFactory.GetItem(ItemType.Shiv);
        var stone = ItemFactory.GetItem(ItemType.Stone);
        var sword = ItemFactory.GetItem(ItemType.Sword);

        items.Add(axe);
        items.Add(bow);
        items.Add(els);
        items.Add(pg);
        items.Add(shiv);
        items.Add(stone);
        items.Add(sword);
       
        //agrego los character a la lista
        characters.Add(martinsito);
        characters.Add(pintonio);
        characters.Add(juancito);
        characters.Add(antoncito);

        //Random random = new Random();
        //int numeroAleatorio = random.Next(0, );

        //Con esto generamos numeros aleatorios para seleccionar id de ITEMS:
        Random rnd = new Random(7);


        // Aca se crea un numero segun el indice de la lista Items, que van desde el 1 al 15
        int randIndex = rnd.Next(0, items.Count );
        int randIndex2 = rnd.Next(0, items.Count);
        int randIndex3 = rnd.Next(0, items.Count);
        int randIndex4 = rnd.Next(0 ,items.Count);

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

        var firstBattle =  Encounters.EncounterFactory.GetEncounter (Encounters.EncounterType.Attack ,this.characters[0],this.characters[1]);
        Console.WriteLine(firstBattle.Character1.Name);
        try
        {
          
          this.battles.Add(firstBattle as AttackEncounter);
        }
         catch (NullReferenceException e) {
          
          Console.WriteLine(" 33" + e);

         } 
        var secondBattle =  Encounters.EncounterFactory.GetEncounter (Encounters.EncounterType.Attack ,this.characters[2],this.characters[3]);
        try
        {
          
          this.battles.Add(secondBattle as AttackEncounter);
        }
         catch (NullReferenceException e) {
          
          Console.WriteLine("34" + e);

         } 
        // nos falta aca ver el que sobrevive de cada pelea
        // USAR LA CLASE ENCOUNTER PARA VER LA PELEA ENTRE DOS PERSONAJES
        // USAR EXCHANGE ENCOUNTER PARA QUE EQUIPEN LOS ITEMS RANDOM QUE HEMOS GENERADOS

      }
      
       public void Run()
       {
         // Batalla entre Personaje 1 y Personaje 2 y 3 y 4;

        battles[0].DoEncounter();
        battles[1].DoEncounter();

        var thirdBattle = Encounters.EncounterFactory.GetEncounter (Encounters.EncounterType.Attack , battles[0].Winner(), battles[1].Winner());
        battles.Add(thirdBattle as AttackEncounter);
        battles[2].DoEncounter();
        Console.WriteLine("El rey de la Tierra Media es: " +  battles[2].Winner().Name);
        
       }
    }
}

