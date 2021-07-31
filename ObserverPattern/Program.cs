using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Observer pattern, automatically notify and update all objects of its dependents.
            // One-to-many dependency. 
            // Using this pattern when some objects need to be update while another object changed its state.
            RunObserver();
        }

        private static void RunObserver()
        {
            HeroCreator creator = new HeroCreator();
            Village village_A = new Village("A");
            Village village_B = new Village("B");
            Village village_C = new Village("C");
            
            Console.WriteLine(" ----- No observer ----- ");
            creator.CreateHero("Ironman");
            creator.NotifyAll();

            Console.WriteLine(" ----- All villages become observer ----- ");
            creator.Add(village_A);
            creator.Add(village_B);
            creator.Add(village_C);
            creator.CreateHero("Thor");
            creator.NotifyAll();

            Console.WriteLine(" ----- Remove village B from observer list ----- ");
            creator.Remove(village_B);
            creator.CreateHero("Spiderman");
            creator.NotifyAll();
        }
    }
}
