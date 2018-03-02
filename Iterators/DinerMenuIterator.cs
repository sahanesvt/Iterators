using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class DinerMenuIterator:IEnumerator//, iIterator
    {
        private MenuItem[] _items;
        private int position = -1;
        
        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        /*public object next()
        {
            MenuItem menuItem = _items[position];
            position++;
            return menuItem;
        }

        public bool hasNext()
        {
            return position >= _items.Length || _items[position] == null ? false : true;
        }*/

        public object Current
        {
            get
            {
                return _current;
            }
        }

        public bool MoveNext()
        {
            position++;
            return position < _items.Count();
        }

        public void Reset()
        {
            position = -1;
        }

        private MenuItem _current
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
