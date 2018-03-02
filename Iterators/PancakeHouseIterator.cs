using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class PancakeHouseIterator:IEnumerator
    {
        private List<MenuItem> _items;
        private int position = -1;
        private int _count = 0;

        public PancakeHouseIterator(List<MenuItem> items)
        {
            _items = items;
        }

        public PancakeHouseIterator(List<MenuItem> items, int start)
        {
            position = start;
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
            return position >= _items.Count() || _items[position] == null ? false : true;
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
            //position++;
            //return position < _items.Count();
            _advancePosition();
            return _count < _items.Count() + 1;
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

        private void _advancePosition()
        {
            position++;
            position = position > _items.Count() - 1 ? 0 : position;
            _count++;
        }
    }
}
