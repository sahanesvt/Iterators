using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class CafeMenu:Menu
    {
        private Dictionary<string, MenuItem> _menuItems = new Dictionary<string, MenuItem>();

        public CafeMenu()
        {
            addItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99);

            addItem("Soup of the day", "A cup of the soup of the day, with a side of salad", false, 3.69);

            addItem("Burrito", "A large burrito, with whole pinto beans, salsa, and guacamole",true,4.29);
        }

        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuitem = new MenuItem(name, description, vegetarian, price);
            _menuItems[menuitem.getName()] = menuitem;
        }

        public iIterator createIterator()
        {
            return new CafeMenuIterator(_menuItems);
        }
    }
}
