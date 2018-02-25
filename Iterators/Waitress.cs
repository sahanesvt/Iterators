using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class Waitress
    {
        private Menu _pancakeHouseMenu;
        private Menu _dinerMenu;
        private Menu _cafeMenu;

        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu, Menu cafeMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
            _cafeMenu = cafeMenu;
        }

        public void printMenu()
        {
            iIterator pancakeIterator = _pancakeHouseMenu.createIterator();
            iIterator dinerIterator = _dinerMenu.createIterator();
            iIterator cafeIterator = _cafeMenu.createIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            printMenu(pancakeIterator);

            Console.WriteLine("\nLUNCH");
            printMenu(dinerIterator);

            Console.WriteLine("\nDINNER");
            printMenu(cafeIterator);
        }

        private void printMenu(iIterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem = (MenuItem) iterator.next();
                Console.WriteLine(menuItem.getName()+" ");
                Console.WriteLine(menuItem.getPrice() + " ");
                Console.WriteLine(menuItem.getDescription());
            }
        }
        
    }
}
