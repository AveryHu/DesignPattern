using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunVisitor();
        }

        public static void RunVisitor()
        {
            Visitor work = new WorkVisitor();
            Visitor sleep = new SleepVisitor();
            Console.WriteLine(" ======== Every career do work ======== ");
            work.visit(new Hero("David"));
            work.visit(new Thief(100000));
            work.visit(new Carpenter(5));
            Console.WriteLine(" ======== Every career do sleep ======== ");
            sleep.visit(new Hero("Avery"));
            sleep.visit(new Thief(415743));
            sleep.visit(new Carpenter(1));
        }
    }
}
