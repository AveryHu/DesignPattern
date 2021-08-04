using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public abstract class Human
    {
        protected string _name;
        protected List<Human> _subordinates;
        public virtual void Add(Human human)
        {
            this._subordinates.Add(human);
        }
        public virtual void Remove(Human human)
        {
            this._subordinates.Remove(human);
        }
        public abstract void Order(string command);
    }
}