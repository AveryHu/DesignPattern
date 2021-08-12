using System;
using System.Collections.Generic;

namespace MediatorPattern
{    
    public enum HeroType : int
    {
        DragonKiller = 0,
        SlimeKiller = 1,
        WerewolfKiller = 2
    }

    public abstract class Mediator
    {
        protected Dictionary<HeroType, Colleague> _colleaguelist;
        public virtual void ApplyasHero(HeroType type, Colleague hero)
        {
            hero.SetMediator(this);
            _colleaguelist.Add(type, hero);
        }
        public virtual void AssignMission(HeroType type, string mission)
        {
            _colleaguelist[type].GetMission(mission);
        }
    }

    public class Guild : Mediator
    {
        public Guild()
        {
            this._colleaguelist = new Dictionary<HeroType, Colleague>();
        }        
    }
}