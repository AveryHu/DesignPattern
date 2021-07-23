using System;

namespace StrategyPattern
{
    public class Human
    {
        private IStrategy strategy;

        public Human(IStrategy career)
        {
            this.strategy = career;
        }
        public void ChangeCareer(IStrategy career)
        {
            this.strategy = career;
            Console.WriteLine(" ------ Career (action) changed ------");
        }
        public void PrintCareer()
        {
            this.strategy.PrintCareer();
        }
        public void Attack()
        {
            this.strategy.Attack();
        }
        public void Defend()
        {
            this.strategy.Defend();
        }
    }
}