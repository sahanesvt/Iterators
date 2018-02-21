using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class Waitress
    {
        private PancakeHouseMenu _pancakeHouseMenu;
        private DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu; 
        }

        public void printMenu()
        {
            iIterator pancakeIterator = _pancakeHouseMenu.createIterator();
            iIterator dinerIterator = _dinerMenu.createIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            printMenu(pancakeIterator);

            Console.WriteLine("\nLUNCH");
            printMenu(dinerIterator);
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
