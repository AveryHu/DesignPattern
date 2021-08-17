using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTemplateMethod();
        }

        private static void RunTemplateMethod()
        {            
            Mission dragonmission = new DragonMission();
            Console.WriteLine(" ======= Dragon Template ======= ");
            dragonmission.DoMission();
            Mission slimemission = new SlimeMission();
            Console.WriteLine(" ======= Slime Template ======= ");
            slimemission.DoMission();
        }
    }
}
