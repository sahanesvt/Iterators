using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class DinerMenuIterator:iIterator 
    {
        private MenuItem[] _items;
        private int position = 0;

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

    }
}
