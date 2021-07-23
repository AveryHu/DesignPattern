using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Strategy pattern makes action changing easier.
            // Easy to extend action. Less usage of 'if/else'.
            // Only have to create a new action and set it as your action.
            // However, you might have a lot of action classes and have to decide which to use.
            RunStrategy();
        }

        private static void RunStrategy()
        {
            Human man = new Human(new Warrior());
            man.PrintCareer();
            man.Attack();
            man.Defend();
            man.ChangeCareer(new Archer());
            man.PrintCareer();
            man.Attack();
            man.Defend();
        }
    }
}
