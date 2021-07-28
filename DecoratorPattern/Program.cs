using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDecorator();
        }

        private static void RunDecorator()
        {
            Human warrior = new Warrior();
            var warrior_fight = new Fight(warrior);
            var warrior_fight_save = new Save(warrior_fight);
            var warrior_fight_save_report = new Report(warrior_fight_save);
            warrior_fight_save_report.PrintCareer();
            warrior_fight_save_report.DoAction();
            
            Console.WriteLine();
            
            Human hunter = new Hunter();
            var hunter_hunt = new Hunt(hunter);
            var hunter_hunt_report = new Report(hunter_hunt);
            hunter_hunt_report.PrintCareer();
            hunter_hunt_report.DoAction();
        }
    }
}
