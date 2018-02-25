using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class CafeMenuIterator:iIterator
    {
        private Dictionary<string, MenuItem> _items = new Dictionary<string, MenuItem>();
        private int position = 0;

        public CafeMenuIterator(Dictionary<string,MenuItem> items)
        {
            _items = items;
        }

        public object next()
        {
            MenuItem menuItem = _items.ElementAt(position).Value;
            position++;
            return menuItem;
        }

        public bool hasNext()
        {
            return position >= _items.Count || _items.ElementAt(position).Value == null ? false : true;
        }



    }
}
