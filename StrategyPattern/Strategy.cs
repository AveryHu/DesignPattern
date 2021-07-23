using System;

namespace StrategyPattern
{
    public interface IStrategy
    {
        void PrintCareer();
        void Attack();
        void Defend();
    }

    public class Warrior : IStrategy
    {
        public void PrintCareer()
        {
            Console.WriteLine("You are a warrior !");
        }
        public void Attack()
        {
            Console.WriteLine("Use a sword to attack !");
        }

        public void Defend()
        {
            Console.WriteLine("Use a shield to defend !");
        }
    }

    public class Archer : IStrategy
    {
        public void PrintCareer()
        {
            Console.WriteLine("You are an archer !");
        }
        public void Attack()
        {
            Console.WriteLine("Use a bow to attack !");
        }

         public void Defend()
        {
            Console.WriteLine("Defensive is not allowed !");
        }
    }
}
