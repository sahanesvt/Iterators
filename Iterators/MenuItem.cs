using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class MenuItem : MenuComponent
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

        public override string getName()
        {
            return _name;
        }

        public override string getDescription()
        {
            return _description;
        }

        public override double getPrice()
        {
            return _price;
        }

        public override bool isVegetarian()
        {
            return _vegetarian;
        }

        public override void print()
        {
            Console.WriteLine("  " + getName());
            if (isVegetarian())
            {
                Console.WriteLine("(v)");
            }
            Console.WriteLine(", " + getPrice());
            Console.WriteLine("    -- " + getDescription());
        }

        public override iIterator createIterator()
        {
            return new NullIterator();
        }
    }
}
