using System;

namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Human
    {
        public Human _human;
    }

    public class Hunt : CondimentDecorator
    {
        public Hunt(Human human)
        {           
            this._human =  human;
            this._career = human._career;
        }

        public override void DoAction()
        {
            this._human.DoAction();
            Console.WriteLine("Kill a wolf.. ");
        }
    }

    public class Fight : CondimentDecorator
    {
        public Fight(Human human)
        {           
            this._human =  human;
            this._career = human._career;
        }

        public override void DoAction()
        {
            this._human.DoAction();
            Console.WriteLine("Fight an enemy.. ");
        }
    }

    public class Save : CondimentDecorator
    {
        public Save(Human human)
        {           
            this._human =  human;
            this._career = human._career;
        }

        public override void DoAction()
        {
            this._human.DoAction();
            Console.WriteLine("Save a princess.. ");
        }
    }

    public class Report : CondimentDecorator
    {
        public Report(Human human)
        {           
            this._human =  human;
            this._career = human._career;
        }

        public override void DoAction()
        {
            this._human.DoAction();
            Console.WriteLine("Report to the king.. ");
        }
    }
}