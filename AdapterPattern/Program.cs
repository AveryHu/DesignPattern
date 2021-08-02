using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Adapter pattern, converts one interface to another which matches the client's expecting.
            // When your old system needs to fit in a new company which have a different interface,
            // this pattern might be helpful.
            RunAdapter();
        }

        private static void RunAdapter()
        {
            Human male = new Male();
            Console.WriteLine(" ----- A real male sing ------");
            male.Sing();
            Console.WriteLine("");
            Monster werewolf = new Werewolf();
            Human fakemale = new Adapter(werewolf);
            Console.WriteLine(" ----- A werewolf disguise as a male to sing ------");
            fakemale.Sing();
        }
    }
}
