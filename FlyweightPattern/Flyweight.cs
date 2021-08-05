using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public class Hero
    {
        private string _name;
        private List<Flyweight> _titles;
        public Hero(string name)
        {
            _name = name;
            _titles = new List<Flyweight>();            
        }
        public void AddTitle(Flyweight title)
        {
            if(!_titles.Contains(title))
                _titles.Add(title);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Hero " + _name);            
            foreach(var t in _titles)
            {
                t.ShowDetail();
            }
        }
    }
    public abstract class Flyweight
    {
        protected string _name;
        protected string _effect;
        public abstract void ShowDetail();
    }

    public class Title : Flyweight
    {
        public Title(string name, string effect)
        {
            this._name = name;
            this._effect = effect;
        }
        public override void ShowDetail()
        {
            Console.WriteLine(_name + " : " + _effect);
        } 
    }
}