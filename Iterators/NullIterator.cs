using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class NullIterator : iIterator
    {
        public bool hasNext()
        {
            return false;
        }

        public object next()
        {
            return null;
        }
    }
}
