using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter8
{
    class Duck : IComparable<Duck>
    {
        public int size;
        public KindOfDuck Kind;

        public int CompareTo(Duck other)
        {
            if(this.size > other.size)
            {
                return 1;
            }
            else if (this.size < other.size)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }


}
