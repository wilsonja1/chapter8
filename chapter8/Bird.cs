using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter8
{
    class Bird
    {
        public string Name { get; set; }
        public virtual void Fly()
        {
            Console.WriteLine("flap, flap");

        }
        public override string ToString()
        {
            return "A bird named " + Name;
        }
    }
}
