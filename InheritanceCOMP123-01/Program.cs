using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCOMP123_01
{
    class Program
    {
        //this is tester 
        static void Main(string[] args)
        {
            //creating a base class object with the help of the default constructor
            BaseClass bc = new BaseClass();
            DerrivedClas dc = new DerrivedClas();

            // calling the methods in association of the base class objects, the correct version will be called: it is called Polymorphism
            bc.Method1();
            bc.Method2();

            //calling the methods in association of the derived class objects, the correct version will be called: Polymorphic call
            dc.Method1();
            dc.Method2();
            Console.ReadKey();
        }
    }

}
