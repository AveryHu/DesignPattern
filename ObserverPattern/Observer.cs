using System;

namespace ObserverPattern
{
    public interface IObserver
    {
        void Update(string heroname);
    }

    public class Village : IObserver
    {
        string _villagename = "Village ";
        public Village(string name)
        {
            this._villagename += name;
        }
        public void Update(string heroname)
        {
            Console.WriteLine(_villagename + " : Rumor has it that there is a new hero named " + heroname);
        }
    }
}