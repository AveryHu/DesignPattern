using System;

namespace TemplateMethodPattern
{
    public abstract class Mission
    {
        public void DoMission()
        {
            FindNPC();

            GoMission();

            ReportNPC();
        }
        public abstract void GoMission();
        private void FindNPC() { Console.WriteLine("Find NPC to get Mission ! "); }
        private void ReportNPC() { Console.WriteLine("Report mission result to NPC ! "); }
    }

    public class DragonMission : Mission
    {
        public override void GoMission()
        {
            Console.WriteLine("Kill the dragon ...");
        }
    }

    public class SlimeMission : Mission
    {
        public override void GoMission()
        {
            Console.WriteLine("Kill the slime ...");
        }
    }
}