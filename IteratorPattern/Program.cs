using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunIterator();
            RunNetIterator();
        }

        private static void RunIterator()
        {            
            Console.WriteLine(" ======= Use my Iterator ======= ");
            Village village = new Village();
            village.Add(new Hero("Dragon Killer"));
            village.Add(new Hero("Slime Killer"));
            village.Add(new Hero("Goblin Killer"));
            village.Add(new Hero("Werewolf Killer"));

            MyIterator myiterator = village.GetMyIterator();
            while(myiterator.HasNext())
            {
                ((Hero)myiterator.Next()).Introduce();
            }
        }

        private static void RunNetIterator()
        {
            Console.WriteLine(" ======= Use .NET Iterator ======= ");            
            Village_Net village = new Village_Net();
            village.Add(new Hero("Werewolf Healer"));            
            village.Add(new Hero("Slime Healer"));
            village.Add(new Hero("Dragon Healer"));
            village.Add(new Hero("Goblin Healer"));

            foreach(Object obj in village)
            {
                ((Hero)obj).Introduce();
            }
        }
    }
}
