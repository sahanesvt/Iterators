using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class CafeMenuIterator:IEnumerator//, iIterator
    {
        private Dictionary<string, MenuItem> _items = new Dictionary<string, MenuItem>();
        private int position = -1;

       

        public CafeMenuIterator(Dictionary<string,MenuItem> items)
        {
            _items = items;
        }

        /*public object next()
        {
            MenuItem menuItem = _items.ElementAt(position).Value;
            position++;
            return menuItem;
        }

        public bool hasNext()
        {
            return position >= _items.Count || _items.ElementAt(position).Value == null ? false : true;
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
                    return _items.ElementAt(position).Value;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
    
}
