using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Flyweight pattern, share some of similar objects to minimizes memory usage.
            // Different hero can share the same title object which has a same ability.
            // Don't need to create a same title object for different hero.
            RunFlyweight();
        }

        private static void RunFlyweight()
        {
            Hero heroone = new Hero("Natori");
            TitleFactory titlefactory = new TitleFactory();
            heroone.AddTitle(titlefactory.GetTitle("Dragon Killer"));
            heroone.AddTitle(titlefactory.GetTitle("Slime Killer"));
            heroone.AddTitle(titlefactory.GetTitle("Handsome"));
            heroone.AddTitle(titlefactory.GetTitle("Thief"));
            heroone.ShowInfo();
            titlefactory.PrintTitleObjectCount();
            Hero herotwo = new Hero("Kenji");
            herotwo.AddTitle(titlefactory.GetTitle("Slime Killer"));
            herotwo.AddTitle(titlefactory.GetTitle("Werewolf"));            
            herotwo.AddTitle(titlefactory.GetTitle("Thief"));
            herotwo.ShowInfo();
            titlefactory.PrintTitleObjectCount();
        }
    }
}
