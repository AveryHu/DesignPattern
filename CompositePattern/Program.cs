using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Composite pattern, objects were composed into a tree structures to represent a part or whole hierachies.
            RunComposite();
        }

        private static void RunComposite()
        {
            Human king_A = new King("A");
            Human knight_A = new Knight("A");
            Human knight_B = new Knight("B");
            Human soldier_A = new Soldier("A");
            Human soldier_B = new Soldier("B");
            Human soldier_C = new Soldier("C");
            king_A.Add(knight_A);
            king_A.Add(knight_B);
            knight_A.Add(soldier_A);
            knight_A.Add(soldier_B);
            knight_B.Add(soldier_C);
            Console.WriteLine(" ============== King A command to fight ================ ");
            king_A.Order("fight");
            Console.WriteLine(" ============== Remove soldier B ================ ");
            Console.WriteLine(" ============== Kight A command to dance ================ ");
            knight_A.Remove(soldier_B);
            knight_A.Order("dance");
        }
    }
}
