using System;
using System.Collections.Generic;

namespace StatePattern
{
    public class Human
    {
        IState currentstate;
        Dictionary<int,IState> states;
        public Human()
        {
            states = new Dictionary<int, IState>();
            states.TryAdd((int)StateType.Daze, new Daze(this));
            states.TryAdd((int)StateType.Guard, new Guard(this));
            states.TryAdd((int)StateType.Counterattack, new Counterattack(this));
            this.currentstate = states[(int)StateType.Daze];
        }
        public void ChangeState(IState state)
        {
            this.currentstate = state;
        }
        public IState GetNextState(StateType type)
        {
            return states[((int)type + 1)%3];
        }
        public void DoSomething()
        {
            Console.Write("Hero do action : ");
            this.currentstate.Action();
        }
    }
}