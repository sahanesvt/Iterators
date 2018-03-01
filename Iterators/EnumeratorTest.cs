using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class EnumeratorTest : IEnumerator
    {
        private List<int> enumerableThing = new List<int>();
        private int position = -1;


        public EnumeratorTest(List<int> list)
        {
            enumerableThing = list;
        }

        public object Current
        {
            get
            {
                return _current;
            }
        }

        public bool MoveNext()
        {
            position++;
            return position < enumerableThing.Count();
        }

        public void Reset()
        {
            position = -1;
        }

        private int _current
        {
            get
            {
                try
                {
                    return enumerableThing[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }
}
