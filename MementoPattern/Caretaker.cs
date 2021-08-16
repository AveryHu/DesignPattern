using System;
using System.Collections.Generic;

namespace MementoPattern
{
    public class Caretaker
    {
        Dictionary<string, Memento> _memlist;

        public Caretaker()
        {
            _memlist = new Dictionary<string, Memento>();
        }
        public Memento GetMemento(string name)
        {
            if(_memlist.TryGetValue(name, out Memento val))
                return val;
            return null;
        }

        public void SetMemento(string name, Memento memo)
        {
            _memlist.Add(name, memo);
        }
    }
}