using System;

namespace BridgePattern
{
    public interface IEmotion
    {
        string GetEmotion();
        void Sing();
        void Kill();
        void Dance();
    }

    public class Happy : IEmotion
    {
        public string GetEmotion()
        {
            return "happy";
        }
        public void Sing()
        {
            Console.WriteLine("Sign => I'm going to sing ~ ");
        }

        public void Kill()
        {
            Console.WriteLine("Kill => I can't do it... ");
        }

        public void Dance()
        {
            Console.WriteLine("Dance => Do you like my dance ?? ");
        }
    }

    public class Mad : IEmotion
    {
        public string GetEmotion()
        {
            return "mad";
        }
        public void Sing()
        {
            Console.WriteLine("Sing => Are you kidding !!?");
        }

        public void Kill()
        {
            Console.WriteLine("Kill => I am going to kill !!!! ");
        }

        public void Dance()
        {
            Console.WriteLine("Dance => No way !!");
        }
    }
}