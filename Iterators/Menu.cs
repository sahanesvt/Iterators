﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class Menu: MenuComponent , IMenu, IEnumerable
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();
        private string _name;
        private string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent getChild(int i)
        {
            return (MenuComponent)_menuComponents[i];
        }

        public override string getName()
        {
            return _name;
        }

        public int Count()
        {
            return _menuComponents.Count();
        }

        public MenuComponent this[int index]
        {
            get
            {
                return _menuComponents[index];
            }
        }

        public override string getDescription()
        {
            return _description;
        }

        public override void print()
        {
            Console.Write("\n" + _name);
            Console.WriteLine(", " + _description);
            Console.WriteLine("---------------------");

            foreach (MenuComponent menuComponent in _menuComponents)
            {
                menuComponent.print();
            }
        }

        private void print(iIterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuComponent menuComponent = (MenuComponent)iterator.next();
                menuComponent.print();

            }
        }

        public override iIterator createIterator()  //Not needed??
        {
            return new MenuIterator(_menuComponents);
        }

        public override IEnumerator GetEnumerator()
        {
            return new MenuEnumerator(this);
        }
    }
}
