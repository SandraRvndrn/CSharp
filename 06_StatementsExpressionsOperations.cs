using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    internal class StatementsExpressionsOperations
    {
        static void Main6(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());

            int s = a + b; //a and b is operand   + is operator

            Console.WriteLine(s);

            //TERNARY OR CONDITIONAL OPERATORS 
            // syntax --> 
            int c = int.Parse(Console.ReadLine());
            string d = (c > 10) ? "A is greater than 10" : "A is less than 10";
            Console.WriteLine(d);

            //PRECIDENCE OF OPERATORS 
            //High lvl --> (), /* , +- , left to right

            int e = 8 / 2 - 3 + 2 * 2;
                    //4-3+2*2
                    //4-3+4
                    //1+4
                    //5
                    
            Console.WriteLine(e);

            Console.ReadLine();

        }
    }
}
