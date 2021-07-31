using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void NotifyAll();
    }

    public class HeroCreator : IObservable
    {
        private List<IObserver> _observerlist;

        private string _lastheroname;
        public HeroCreator()
        {
            this._observerlist = new List<IObserver>();
            this._lastheroname = "No hero";
        }

        public void Add(IObserver observer)
        {
            _observerlist.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _observerlist.Remove(observer);
        }

        public void CreateHero(string name)
        {
            _lastheroname = name;
        }

        public void NotifyAll()
        {
            foreach(var o in _observerlist)
            {
                o.Update(_lastheroname);
            }
        }
    }
}