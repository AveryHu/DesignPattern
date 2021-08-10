using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    public abstract class Aggregate
    {
        protected List<Object> _list;
        public virtual void Add(Object item)
        {
            _list.Add(item);
        }
        public virtual void Remove(Object item)
        {
            _list.Remove(item);
        }
        public abstract MyIterator GetMyIterator();
    }

    public class Village : Aggregate
    {
        public Village()
        {
            _list = new List<object>();
        }
        public override MyIterator GetMyIterator()
        {
            return new HeroIterator(this._list);
        }
    }

    public class Village_Net : IEnumerable<Object>
    {
        private List<Object> _list;
        public Village_Net()
        {
            this._list = new List<Object>();
        }
        public void Add(Object obj)
        {
            _list.Add(obj);
        }
        public void Remove(Object obj)
        {
            _list.Remove(obj);
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }        
        public IEnumerator<Object> GetEnumerator()
        {
            return new HeroIterator_Net(_list);
        }       
    }

    public class Hero
    {
        private string _name;
        public Hero(string name)
        {
            this._name = name;
        }
        public void Introduce()
        {
            Console.WriteLine("Hey, I'm " + _name);
        }
    }
}
