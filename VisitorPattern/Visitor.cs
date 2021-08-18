using System;

namespace VisitorPattern
{
    public interface Visitor
    {
        void visit(Hero hero);
        void visit(Thief thief);
        void visit(Carpenter carpenter);
    }

    public class WorkVisitor : Visitor
    {
        public void visit(Hero hero)
        {
            Console.WriteLine("I'm Hero " + hero._name + ". I'm going to kill the dragon.");
        }
        public void visit(Thief thief)
        {
            Console.WriteLine("My bounty is " + thief._bounty + " dollars. I'm going to steal money.");
        }
        public void visit(Carpenter carpenter)
        {
            Console.WriteLine("I'm level " + carpenter._level + " carpenter. I can build a house.");
        }
    }

    public class SleepVisitor : Visitor
    {
        public void visit(Hero hero)
        {
            Console.WriteLine("I'm Hero " + hero._name + ". I'm don't need to sleep.");
        }
        public void visit(Thief thief)
        {
            Console.WriteLine("My bounty is " + thief._bounty + " dollars. I can't sleep.");
        }
        public void visit(Carpenter carpenter)
        {
            Console.WriteLine("I'm level " + carpenter._level + " carpenter. I have to sleep now.");
        }
    }
}