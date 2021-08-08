using System;

namespace ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        protected Handler _next;
        public virtual void SetNext(Handler next)
        {
            this._next = next;
        }
        public abstract void HandleRequest(string request);
    }

    public class King : Handler
    {
        public override void HandleRequest(string request)
        {
            if(request.Equals("destory kingdom A"))
            {
                Console.WriteLine("I'm king, let's destory kingdom A");
            }
            else
            {
                Console.WriteLine("King : Who can " + request + " ?");
                _next.HandleRequest(request);
            }
        }
    }

    public class Knight : Handler
    {
        public override void HandleRequest(string request)
        {
            if(request.Equals("kill the dragon"))
            {
                Console.WriteLine("I'm knight, i can kill the dragon.");
            }
            else
            {
                Console.WriteLine("Knight : Who can " + request + " ?");
                _next.HandleRequest(request);
            }
        }
    }

    public class Village : Handler
    {
        public override void HandleRequest(string request)
        {
            if(request.Equals("build a house"))
            {
                Console.WriteLine("I'm village, let me build a house");
            }
        }
    }
}