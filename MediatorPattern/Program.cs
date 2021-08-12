using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Mediator pattern, classes are decoupled from one-many association to one-one association
            // Too many colleagues will cause the mediator take too much responsibilities.
            RunMediator();
        }

        private static void RunMediator()
        {
            Mediator guild = new Guild();
            DragonHero hero_one = new DragonHero();
            SlimeHero hero_two = new SlimeHero();
            WerewolfHero hero_three = new WerewolfHero();
            guild.ApplyasHero(HeroType.DragonKiller, hero_one);
            guild.ApplyasHero(HeroType.SlimeKiller, hero_two);
            guild.ApplyasHero(HeroType.WerewolfKiller, hero_three);

            hero_one.SendMission(HeroType.SlimeKiller, "Kill Fire Slime");
            Console.WriteLine();            
            hero_three.SendMission(HeroType.SlimeKiller, "Kill Water Slime");
            Console.WriteLine();  
            hero_two.SendMission(HeroType.WerewolfKiller, "Kill Werewolf King");
            Console.WriteLine();  
            hero_three.SendMission(HeroType.DragonKiller, "Kill Water Dragon");
        }
    }
}
