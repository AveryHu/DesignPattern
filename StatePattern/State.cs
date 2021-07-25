using System;

namespace StatePattern
{
    public interface IState
    {
        void Action();
    }
    public enum StateType : int
    {
        Daze = 0,
        Guard = 1,
        Counterattack = 2
    }
    public class Daze : IState
    {
        private Human me;

        public Daze(Human man)
        {
            this.me = man;
        }
        public void Action()
        {
            Console.WriteLine("Didn't notice an enemy's attack. Get hurt..");
            me.ChangeState(me.GetNextState(StateType.Daze));
        }
    }
    public class Guard : IState
    {
        private Human me;

        public Guard(Human man)
        {
            this.me = man;
        }
        public void Action()
        {
            Console.WriteLine("Defend self by using a shield.. Prepare to fight back..");
            me.ChangeState(me.GetNextState(StateType.Guard));
        }
    }
    public class Counterattack : IState
    {
        private Human me;

        public Counterattack(Human man)
        {
            this.me = man;
        }
        public void Action()
        {
            Console.WriteLine("Fire !!!!! Get tired and become dazed.. ");
            me.ChangeState(me.GetNextState(StateType.Counterattack));
        }
    }
}