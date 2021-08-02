using System;

namespace AdapterPattern
{
    public abstract class Monster
    {
        public abstract void Howl();
    }

    public class Werewolf : Monster
    {
        public override void Howl()
        {
            Console.WriteLine("Ahh ~  wooooo ~~");
        }
    }
}