using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    class Program
    {
        /*static void testMenuItems_1()
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            List<MenuItem> breakfastItems = pancakeHouseMenu.getMenuItems();

            DinerMenu dinerMenu = new DinerMenu();
            MenuItem[] lunchItems = dinerMenu.getMenuItems();

            for (int i = 0; i < breakfastItems.Count(); i++)
            {
                MenuItem menuItem = breakfastItems[i];
                Console.WriteLine(menuItem.getName()+" ");
                Console.WriteLine(menuItem.getPrice() + " ");
                Console.WriteLine(menuItem.getDescription() + " ");
            }

            for (int i = 0; i < lunchItems.Length; i++)
            {
                if (lunchItems[i] != null)
                {
                    MenuItem menuItem = lunchItems[i];
                    Console.WriteLine(menuItem.getName() + " ");
                    Console.WriteLine(menuItem.getPrice() + " ");
                    Console.WriteLine(menuItem.getDescription() + " ");
                }
            }
        }*/

        static void testWaitress()
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            waitress.printMenu();
        }

        static void Main(string[] args)
        {
            //testMenuItems_1();
            testWaitress();
        }
    }
}
