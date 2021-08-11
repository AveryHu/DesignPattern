using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Command pattern, separate the role who invoke command and who do the command.
            // Easy to add a new command and reuse the same command
            RunCommand();
        }

        private static void RunCommand()
        {
            Receiver boxer = new Receiver("Ray");
            Receiver boxer_two = new Receiver("Jack");

            Invoker coach = new Invoker();

            Command jabaction = new Jab(boxer);
            Command crossaction = new Cross(boxer);
            Command risingblockaction = new RisingBlock(boxer);
            Command lowblockaction_two = new LowBlock(boxer_two);
            Command jabaction_two = new Jab(boxer_two);
            Command hookaction_tow = new Hook(boxer_two);

            coach.SetCommand(jabaction);            
            coach.SetCommand(lowblockaction_two);
            coach.SetCommand(crossaction);            
            coach.SetCommand(jabaction_two);
            coach.SetCommand(risingblockaction);
            coach.SetCommand(hookaction_tow);

            coach.ExecuteCommand();
        }
    }
}
