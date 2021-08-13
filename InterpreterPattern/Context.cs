using System;

namespace InterpreterPattern
{
    public class Context
    {
        private string _text;
        public string Text 
        {
            get
            {
                return _text;
            } 
        }
        public Context(string text)
        {
            this._text = text;
        }         
    }
}
