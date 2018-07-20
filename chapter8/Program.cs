using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>() {
                new Duck() { Kind=KindOfDuck.Mallard, size = 17},
                new Duck() { Kind = KindOfDuck.Decoy, size = 17 },
                new Duck() { Kind = KindOfDuck.Mallard, size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, size = 17 },
                new Duck() { Kind = KindOfDuck.Mallard, size = 17 },
            };

        }
    }
}
