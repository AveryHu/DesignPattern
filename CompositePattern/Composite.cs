using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class King : Human
    {
        public King(string name)
        {
            _name = name;
            _subordinates = new List<Human>();
        }
        public override void Order(string command)
        {
            Console.WriteLine("King " + _name + " : I command you to " + command);
            foreach(Human subordinate in _subordinates)
            {
                subordinate.Order(command);
            }
        }
    }

    public class Knight : Human
    {
        public Knight(string name)
        {            
            _name = name;
            _subordinates = new List<Human>();
        }
        public override void Order(string command)
        {
            Console.WriteLine("|---- Knight " + _name + " : I command you to " + command);
            foreach(Human subordinate in _subordinates)
            {
                subordinate.Order(command);
            }
        }
    }
}