using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class DinerMenuIterator:iIterator, IEnumerator
    {
        private MenuItem[] _items;
        private int position = 0;
        private int _position = -1;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public object next()
        {
            MenuItem menuItem = _items[position];
            position++;
            return menuItem;
        }

        public bool hasNext()
        {
            return position >= _items.Length || _items[position] == null ? false : true;
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
                    return _items[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
