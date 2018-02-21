using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class MenuItem
    {
        private string _name;
        private string _description;
        private bool _vegetarian;
        private double _price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public string getName()
        {
            return _name;
        }

        public string getDescription()
        {
            return _description;
        }

        public double getPrice()
        {
            return _price;
        }

        public bool isVegetarian()
        {
            return _vegetarian;
        }

    }
}
