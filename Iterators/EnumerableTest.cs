using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class EnumerableTest : IEnumerable
    {
        private List<int> _listOfInts = new List<int>();

        public EnumerableTest(List<int> intList)
        {
            _listOfInts = intList;
        }

        public IEnumerator GetEnumerator()
        {
            return new EnumeratorTest(_listOfInts);
        }


    }
}
