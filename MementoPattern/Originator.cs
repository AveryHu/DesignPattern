using System;

namespace MementoPattern
{
    public class Originator
    {    
        private int _hp;
        private int _mp;
        public Originator(int hp, int mp)
        {
            this._hp = hp;
            this._mp = mp;
            Console.WriteLine(" ===== Hero State =====");
            Console.WriteLine("HP : " + _hp);
            Console.WriteLine("MP : " + _mp);
        }
        public Memento CreateMemo()
        {
            return new Memento(_hp,_mp);
        }
        public void RestoreMemo(Memento memo)
        {
            _hp = memo.HP;
            _mp = memo.MP;
            Console.WriteLine(" ===== Hero State =====");
            Console.WriteLine("HP : " + _hp);
            Console.WriteLine("MP : " + _mp);
        }
        public void Fight()
        {
            Random randomobj = new Random();
            Console.WriteLine("Fight with dragon !!");
            _hp -=  randomobj.Next(0,50);
            _mp -= randomobj.Next(0,30);
            Console.WriteLine(" ===== State after fight =====");
            Console.WriteLine("HP : " + _hp);
            Console.WriteLine("MP : " + _mp);
        }
    }
}