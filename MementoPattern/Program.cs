using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMemento();
        }

        private static void RunMemento()
        {
            Caretaker GM = new Caretaker();
            Originator hero = new Originator(100,100);
            Console.WriteLine(" ====== Save Memo as Init ====== ");
            GM.SetMemento("Init", hero.CreateMemo());
            hero.Fight();
            Console.WriteLine(" ====== Save Memo when fight dragon once ====== ");
            GM.SetMemento("FightOnce", hero.CreateMemo());
            hero.Fight();
            hero.Fight();
            hero.Fight();
            Console.WriteLine(" ====== Restore to Init ====== ");
            hero.RestoreMemo(GM.GetMemento("Init"));
            Console.WriteLine(" ====== Restore to fight dragon once ====== ");
            hero.RestoreMemo(GM.GetMemento("FightOnce"));
        }
    }
}
