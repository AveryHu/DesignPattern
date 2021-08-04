using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Soldier : Human
    {
        public Soldier(string name)
        {
            _name = name;
            _subordinates = null;
        }
         // Leaf cannot add or remove
        public override void Add(Human human) { }
        public override void Remove(Human human) { }
        public override void Order(string command)
        {
            Console.WriteLine("|-------- Soldier " + _name + " : Let's " + command);
        }
    }
}