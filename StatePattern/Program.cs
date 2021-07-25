using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using State pattern can extend a new state easier. Less usage of 'if/else'.
            // Use this pattern when your action would be changed while you have different state.
            // However, this might have a lot of state classes which make code more complex.
            RunState();
        }

        private static void RunState()
        {
            Human hero = new Human();
            hero.DoSomething();
            Console.WriteLine(" --- State Change --- ");
            hero.DoSomething();
            Console.WriteLine(" --- State Change --- ");
            hero.DoSomething();
            Console.WriteLine(" --- State Change --- ");
            hero.DoSomething();
        }
    }
}
