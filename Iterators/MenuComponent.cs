using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public abstract class MenuComponent:iIterator,IMenu, IEnumerable
    {
        public virtual void add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent getChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual string getName()
        {
            throw new NotSupportedException();
        }

        public virtual string getDescription()
        {
            throw new NotSupportedException();
        }

        public virtual double getPrice()
        {
            throw new NotSupportedException();
        }

        public virtual bool isVegetarian()
        {
            throw new NotSupportedException();
        }

        public virtual void print()
        {
            throw new NotSupportedException();
        }

        public virtual bool hasNext()
        {
            throw new NotImplementedException();
        }

        public virtual object next()
        {
            throw new NotImplementedException();
        }

        public virtual iIterator createIterator()
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
