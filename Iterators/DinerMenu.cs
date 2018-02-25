using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class DinerMenu:Menu
    {
        private static readonly int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        private MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];

            addItem("Vegetarian BLT", "(Fakin) Bacon with lettuce & tomato on whole wheat", true, 2.99);

            addItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);

            addItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);

            addItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);

            addItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99);

            addItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89);
        }

        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if(_numberOfItems >= MAX_ITEMS)
            {
                throw new Exception("Sorry, menu is full!  Can't add item to menu"); 
            }
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }
        
        /*public MenuItem[] getMenuItems()
        {
            return _menuItems;
        }*/

        public iIterator createIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }


    }
}
