using System;
using System.Collections.Generic;

namespace CommandPattern
{
    public class Receiver
    {
        private string _name;
        public Receiver(string name)
        {
            this._name = name;
        }
        public void Attack(string action)
        {
            Console.WriteLine(_name + " : " + action + " attack !!! ");
        }

        public void Defend(string action)
        {
            Console.WriteLine(_name + " : " + "Defend by using " + action);
        }
    }
}