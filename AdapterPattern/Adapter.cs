using System;

namespace AdapterPattern
{
    public class Adapter : Human
    {
        Monster _monster;
        public Adapter(Monster monster)
        {
            this._monster = monster;
        }

        public override void Sing()
        {
            Console.Write("Howl with rhythm !! ");
            _monster.Howl();
        }
    }
}