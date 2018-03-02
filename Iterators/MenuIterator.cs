using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class MenuIterator//: iIterator  CLASS NOT USED
    {
        private List<MenuComponent> _menuComponents= new List<MenuComponent>();
        private int position = 0;

        public MenuIterator(List<MenuComponent> menuComponents)
        {
            _menuComponents = menuComponents;
        }

        public MenuIterator(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public object next()
        {
            MenuComponent menuComponents = _menuComponents[position];
            position++;
            return menuComponents;
        }

        public bool hasNext()
        {
            return position >= _menuComponents.Count() || _menuComponents[position] == null ? false : true;
        }
    }
}
