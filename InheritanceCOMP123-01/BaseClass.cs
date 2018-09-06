using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCOMP123_01
{
    class BaseClass
    {
        //Declaring a virtual method which will be overriden in the child class
        public virtual void Method1()
        {
            Console.WriteLine("\nI am reporting from base class Mehtod1()");
        }
        //declaring another virutal method which also will be overrriden in the child class
        public virtual void Method2()
        {
            Console.WriteLine("\nI am reporting from base class Mehtod2()");
        }
        
    }
}
