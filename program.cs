using System;
using System.Collections.Generic;

namespace Mod1Assignment{

    class Program{
        static void Main(string[] args){
           
           List<Talkable> zoo = new List<Talkable>();
           Add add = new Add();

           zoo.Add(add.add());
           zoo.Add(add.add());
           zoo.Add(add.add());

            foreach(Talkable thing in zoo){
                Console.WriteLine(thing);
           }

           Console.WriteLine();

           foreach(Talkable thing in zoo){
                Console.WriteLine(thing.GetName() + " | " + thing.Talk());
           }
          }
        }

    }
   



