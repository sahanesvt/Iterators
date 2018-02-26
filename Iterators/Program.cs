using System;
using System.Collections;
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

            PancakeHouseMenu oldPancakeHouseMenu = new PancakeHouseMenu();
            iIterator oldPancakeHouseMenuIterator = oldPancakeHouseMenu.createIterator();
            DinerMenu oldDinerMenu = new DinerMenu();
            iIterator oldDinerMenuIterator = oldDinerMenu.createIterator();
            CafeMenu oldCafeMenu = new CafeMenu();
            iIterator oldCafeMenuIterator = oldCafeMenu.createIterator();
            //Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);

            /*List<IMenu> menus = new List<IMenu>();
            menus.Add(new PancakeHouseMenu());
            menus.Add(new DinerMenu());
            menus.Add(new CafeMenu());


            Waitress waitress = new Waitress(menus);
            */

            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu(" DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");
            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.add(pancakeHouseMenu);
            allMenus.add(dinerMenu);
            allMenus.add(cafeMenu);

            while (oldPancakeHouseMenuIterator.hasNext())
            {
                pancakeHouseMenu.add((MenuItem)oldPancakeHouseMenuIterator.next());
            }

            while (oldDinerMenuIterator.hasNext())
            {
                dinerMenu.add((MenuItem)oldDinerMenuIterator.next());
            }

            while (oldCafeMenuIterator.hasNext())
            {
                cafeMenu.add((MenuItem)oldCafeMenuIterator.next());
            }

            dinerMenu.add(dessertMenu);
            dessertMenu.add(new MenuItem("Apple Pie", "Apple pie with a flakey crust, topped with vanilla icecream", true, 1.59));

            Waitress waitress = new Waitress(allMenus);
            waitress.printMenu();
        }

        static void Main(string[] args)
        {
            //testMenuItems_1();
            testWaitress();

            /*Person[] peopleArray = new Person[3]
                {
                    new Person("John", "Smith"),
                    new Person("Jim", "Johnson"),
                    new Person("Sue", "Rabon"),
                };

            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
                Console.WriteLine(p.firstName + " " + p.lastName);*/



        }







        public class Person
        {
            public Person(string fName, string lName)
            {
                this.firstName = fName;
                this.lastName = lName;
            }

            public string firstName;
            public string lastName;
        }

        // Collection of Person objects. This class
        // implements IEnumerable so that it can be used
        // with ForEach syntax.
        public class People : IEnumerable
        {
            private Person[] _people;
            public People(Person[] pArray)
            {
                _people = new Person[pArray.Length];

                for (int i = 0; i < pArray.Length; i++)
                {
                    _people[i] = pArray[i];
                }
            }

            // Implementation for the GetEnumerator method.
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)GetEnumerator();
            }

            public PeopleEnum GetEnumerator()
            {
                return new PeopleEnum(_people);
            }
        }

        // When you implement IEnumerable, you must also implement IEnumerator.
        public class PeopleEnum : IEnumerator
        {
            public Person[] _people;

            // Enumerators are positioned before the first element
            // until the first MoveNext() call.
            int position = -1;

            public PeopleEnum(Person[] list)
            {
                _people = list;
            }

            public bool MoveNext()
            {
                position++;
                return (position < _people.Length);
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public Person Current
            {
                get
                {
                    try
                    {
                        return _people[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }


    }
}
