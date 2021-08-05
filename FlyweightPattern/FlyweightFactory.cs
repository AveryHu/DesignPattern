using System;
using System.Collections;

namespace FlyweightPattern
{    
    public class TitleFactory
    {
        private Hashtable _titlemap;
        public TitleFactory()
        {
            _titlemap = new Hashtable();
        }
        public Title GetTitle(string name)
        {
            if(_titlemap.Contains(name))
                return (Title)_titlemap[name];
            else
            {
                Random random = new Random();
                Title title = new Title(name,"ATK+" + random.Next(0, 100).ToString());
                _titlemap.Add(name, title);
                return title;
            }
        }
        public void PrintTitleObjectCount()
        {
            Console.WriteLine("=== Current title object count : " + _titlemap.Count + " ===");
        }
    }
}