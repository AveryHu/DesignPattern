using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Facade pattern, decouple a client from the system.
            // Try use this pattern when having a complex system.
            // Modification of system will not affect the client. 
            RunFacade();
        }

        private static void RunFacade()
        {
            Facade facade = new Facade();
            Console.WriteLine(" ------ Physical attack ------ ");
            facade.PhysicalAttack();
            Console.WriteLine(" ------ Magical attack ------ ");
            facade.MagicalAttack();
        }
    }
}
