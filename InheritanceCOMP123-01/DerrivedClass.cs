using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCOMP123_01
{
    class DerrivedClas:BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("\nI am reporting from derrived class overriden Method1()");
        }
        public override void Method2()
        {
            Console.WriteLine("\nI am reporting from derrivded class overriden Method2()");
        }
    }
}
