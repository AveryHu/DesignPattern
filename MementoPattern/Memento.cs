using System;

namespace MementoPattern
{
    public class Memento
    {
        private int _hp;
        private int _mp;
        
        public Memento(int hp, int mp)
        {
            this._hp = hp;
            this._mp = mp;
        }

        public int HP { get{ return _hp;}}
        public int MP { get{return _mp;}}
    }
}