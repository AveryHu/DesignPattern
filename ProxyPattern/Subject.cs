using System;

namespace ProxyPattern
{
    public interface Subject
    {
        void MissionRequest(string mission);
    }

    public class Hero : Subject
    {
        public void MissionRequest(string mission)
        {
            Console.WriteLine();
            Console.WriteLine(" ---- Hero accept the request (Real Subject) ---- ");
            Console.WriteLine("I'm hero. I can " + mission);
            Console.WriteLine(mission + " succeeded !");
            Console.WriteLine();
        }
    }
}
