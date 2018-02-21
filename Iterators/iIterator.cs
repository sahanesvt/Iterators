using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public interface iIterator
    {
        bool hasNext();
        object next();
    }
}
