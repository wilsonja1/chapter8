using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter8
{
    class Duck : Bird, IComparable<Duck>
    {
        public int size;
        public KindOfDuck Kind;

        public override void Fly()
        {
            Console.WriteLine("Ducks can fly!");
        }

        public override string ToString()
        {
            return "A duck named " + base.Name;
        }

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

        //public override string ToString()
        //{
         //   return this.size.ToString();
        //}
    }

    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }


}
