using System;
using System.Collections.Generic;

namespace CommandPattern
{
    public class Invoker
    {
        List<Command> _list;

        public Invoker()
        {
            _list = new List<Command>();
        }

        public void SetCommand(Command cmd)
        {
            _list.Add(cmd);
        }

        public void ExecuteCommand()
        {
            Console.WriteLine(" ======= Let's start !!!! =======");
            foreach(var cmd in _list)
                cmd.Execute();
        }
    }
}