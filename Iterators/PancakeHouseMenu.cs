using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Iterators
{
    public class PancakeHouseMenu:IMenu
    {
        private List<MenuItem> _menuItems = new List<MenuItem>();

        public PancakeHouseMenu()
        {
            addItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);

            addItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);

            addItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);

            addItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem);
        }

        public List<MenuItem> getMenuItems()
        {
            return _menuItems;
        }

        public iIterator createIterator()
        {
            return new PancakeHouseIterator(_menuItems);
        }




    }
}
