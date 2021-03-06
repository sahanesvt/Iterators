﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class PancakeHouseIterator:iIterator
    {
        private List<MenuItem> _items;
        private int position = 0;

        public PancakeHouseIterator(List<MenuItem> items)
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
            return position >= _items.Count() || _items[position] == null ? false : true;
        }
    }
}
