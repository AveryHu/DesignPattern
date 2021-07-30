using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Bridge pattern, decreasing the need of inheritance.
            // Split of abstraction and implementation makes everything more independent
            // Also you can develop each abstraction or implementation without any influence from other class
            RunBridge();
        }

        private static void RunBridge()
        {
            IAnimal happy_human = new Human(new Happy());
            happy_human.DoSomething();
            Console.WriteLine();
            IAnimal happy_lion = new Lion(new Happy());
            happy_lion.DoSomething();
            Console.WriteLine();
            IAnimal mad_human = new Human(new Mad());
            mad_human.DoSomething();
            Console.WriteLine();
            IAnimal mad_lion = new Lion(new Mad());
            mad_lion.DoSomething();
        }
    }
}
