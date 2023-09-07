using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//VAR is value type
//DYBAMIC is reference type

namespace C_Learnings
{
    internal class VarAndDynamic
    {
        public static dynamic show(dynamic a)
        { return a; }
        static void Main17(string[] args)
        {

            
            int f= VarAndDynamic.show(15);
            Console.WriteLine(f);


            var a = "Hi";
            var b = 12;

            dynamic c = 10;
            c = "hi";

            Console.WriteLine(a.Length);
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(c);

            Console.ReadLine();

        }
    }
}
