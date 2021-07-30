using System;

namespace BridgePattern
{
    public interface IAnimal
    {
        void DoSomething();
    }

    public class Human : IAnimal
    {
        IEmotion _emotion;
        public Human(IEmotion emotion)
        {
            this._emotion = emotion;
            Console.WriteLine("--- I'm a " + this._emotion.GetEmotion() + " man ---");
        }
        public void DoSomething()
        {
            _emotion.Sing();
            _emotion.Dance();
        }
    }

    public class Lion : IAnimal
    {
        IEmotion _emotion;
        public Lion(IEmotion emotion)
        {
            this._emotion = emotion;
            Console.WriteLine("--- I'm a " + this._emotion.GetEmotion() + " lion ---");
        }
        public void DoSomething()
        {
            _emotion.Dance();
            _emotion.Kill();
        }
    }
}