using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class CafeMenuIterator:IEnumerator
    {
        private Dictionary<string, MenuItem> _items = new Dictionary<string, MenuItem>();
        private int _position = -1;

        public CafeMenuIterator(Dictionary<string,MenuItem> items)
        {
            _items = items;
        }



        public bool MoveNext()
        {
            _position++;
            return (_position < _items.Count());
        }
        public void Reset()
        {
            _position = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public MenuItem Current
        {
            get
            {
                try
                {
                    return _items.ElementAt(_position).Value;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


    }
}
