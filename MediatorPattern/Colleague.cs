using System;

namespace MediatorPattern
{
    public abstract class Colleague
    {
        protected Mediator _mediator;
        public virtual void SetMediator(Mediator med)
        {
            this._mediator = med;
        }
        public abstract void SendMission(HeroType targettype, string mission);        
        public abstract void GetMission(string mission);
    }

    public class DragonHero : Colleague
    {
        public override void SendMission(HeroType targettype, string mission)
        {
            Console.WriteLine("I'm Dragon Killer. Ask guild to find someone to do the mission : " + mission);
            this._mediator.AssignMission(targettype, mission);        
        }
        public override void GetMission(string mission)
        {
            Console.WriteLine("I'm Dragon Killer. I took the mission : " + mission);
        }
    }

    public class SlimeHero : Colleague
    {
        public override void SendMission(HeroType targettype, string mission)
        {
            Console.WriteLine("I'm Slime Killer. Ask guild to find someone to do the mission : " + mission);
            this._mediator.AssignMission(targettype, mission);        
        }
        public override void GetMission(string mission)
        {
            Console.WriteLine("I'm Slime Killer. I took the mission : " + mission);
        }
    }

    public class WerewolfHero : Colleague
    {
        public override void SendMission(HeroType targettype, string mission)
        {
            Console.WriteLine("I'm Werewolf Killer. Ask guild to find someone to do the mission : " + mission);
            this._mediator.AssignMission(targettype, mission);        
        }
        public override void GetMission(string mission)
        {
            Console.WriteLine("I'm Werewolf Killer. I took the mission : " + mission);
        }
    }
}