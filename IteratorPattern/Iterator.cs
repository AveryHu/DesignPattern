using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    public abstract class MyIterator
    {
        protected List<Object> _list;
        protected int _position;
        public virtual bool HasNext()
        {
            return (_position < _list.Count) ? true : false;           
        }
        public virtual Object Next()
        {
            return _list[_position++];
        }
    }

    public class HeroIterator : MyIterator
    {
        public HeroIterator(List<Object> list)
        {
            this._list = list;
            this._position = 0;
        }
    }

    public class HeroIterator_Net : IEnumerator<Object>
    {
        private List<Object> _list;
        private int _position;
        public HeroIterator_Net(List<Object> list)
        {
            this._list = list;
            this._position = -1;
        }

        public void Dispose()
        {
            _list.Clear();
        }
        public bool MoveNext()
        {
            _position++;
            return (_position < _list.Count);
        }
        public void Reset()
        {
            _position = -1;
        }
        Object IEnumerator<Object>.Current
        {
            get
            {
                return Current;
            }
        }
        public Object Current
        {
            get
            {
                try
                {
                    return _list[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}