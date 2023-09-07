using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    class ConstantVariable

    {
        public const double PI = 3.14; //const is the identifier of the the variable constant
                                      
        static void Main4(string[] args)
        {
           /* public*/ const double PI = 3.14; //public can use when we initialise a constant inside class, if we are initialising it inside method we don't have to use public
            Console.WriteLine(PI);
            Console.ReadLine();
        }

    }
}
