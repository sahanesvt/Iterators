using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class MenuEnumerator : IEnumerator
    {
        private Menu _menu;
        private int position = -1;


        public MenuEnumerator(Menu menu)
        {
            _menu = menu;
        }

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
            return position < _menu.Count();
        }

        public void Reset()
        {
            position = -1;
        }

        private MenuComponent _current
        {
            get
            {
                try
                {
                    return _menu[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
