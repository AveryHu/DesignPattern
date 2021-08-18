using System;

namespace VisitorPattern
{
    public interface Element
    {
        void accept(Visitor visitor);        
    }

    public class Hero : Element
    {
        public string _name;
        public Hero(string name)
        {
            this._name = name;
        }
        public void accept(Visitor visitor)
        {
            visitor.visit(this);
        }
    }

    public class Thief : Element
    {
        public int _bounty;
        public Thief(int bounty)
        {
            _bounty = bounty;
        }
        public void accept(Visitor visitor)
        {
            visitor.visit(this);
        }
    }

    public class Carpenter : Element
    {
        public int _level;
        public Carpenter(int level)
        {
            _level = level;
        }
        public void accept(Visitor visitor)
        {
            visitor.visit(this);
        }
    }
}