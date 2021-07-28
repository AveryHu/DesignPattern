using System;

namespace DecoratorPattern
{
    public abstract class Human
    {
        public string _career = "villager";
        public void PrintCareer()
        {
            Console.WriteLine("I'm a " + _career);
        }
        public abstract void DoAction();
    }

    public class Hunter : Human
    {
        public Hunter()
        {
            _career = "hunter";
        }

        public override void DoAction()
        {
            Console.WriteLine(" ----- Get a bow and start the missions ----- ");
        }
    }

    public class Warrior : Human
    {
        public Warrior()
        {
            _career = "warrior";
        }

        public override void DoAction()
        {
            Console.WriteLine(" ----- Get a sword and start the missions ----- ");
        }
    }
}