using System;

namespace CommandPattern
{
    public abstract class Command
    {
        protected Receiver _boxer;
        public abstract void Execute();
    }

    public class Jab : Command
    {
        public Jab(Receiver boxer)
        {
            this._boxer = boxer;
        }
        public override void Execute()
        {
            _boxer.Attack("Jab");
        }
    }
    public class Cross : Command
    {
        public Cross(Receiver boxer)
        {
            this._boxer = boxer;
        }
        public override void Execute()
        {
            _boxer.Attack("Cross");
        }
    }
    public class Hook : Command
    {
        public Hook(Receiver boxer)
        {
            this._boxer = boxer;
        }
        public override void Execute()
        {
            _boxer.Attack("Hook");
        }
    }
    public class RisingBlock : Command
    {
        public RisingBlock(Receiver boxer)
        {
            this._boxer = boxer;
        }
        public override void Execute()
        {
            _boxer.Defend("Rising block");
        }
    }

    public class LowBlock : Command
    {
        public LowBlock(Receiver boxer)
        {
            this._boxer = boxer;
        }
        public override void Execute()
        {
            _boxer.Defend("Low block");
        }
    }
}