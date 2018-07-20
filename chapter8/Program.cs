﻿using System;
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
                new Duck() { Kind = KindOfDuck.Decoy, size = 12 },
                new Duck() { Kind = KindOfDuck.Mallard, size = 22 },
                new Duck() { Kind = KindOfDuck.Muscovy, size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, size = 13 },
            };

            ducks.Sort();
            foreach(Duck d in ducks)
            {
                Console.WriteLine(d.size);
            }

            Console.ReadKey();
        }
    }
}
