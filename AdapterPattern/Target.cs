using System;

namespace AdapterPattern
{
    public abstract class Human
    {
        public abstract void Sing();
    }

    public class Male : Human
    {
        public override void Sing()
        {
            Console.WriteLine("We will, we will rock you ~~~");
        }
    }
}