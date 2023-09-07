using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    public class consoleApplication
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Write your first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Write your last name");
            string lname = Console.ReadLine();

            Console.WriteLine("Your name is {0} {1}",fname,lname);  /*Placeholder method*/
            Console.WriteLine("Your name is " + fname +" "+ lname);  /*concatenation method*/

            Console.WriteLine("Write 1st number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write 2nd number");
            int n2 = int.Parse(Console.ReadLine());
            int sum = n1 + n2;

            Console.WriteLine("Sum of {0} and {1} is {2}", n1, n2, sum);  /*Placeholder method*/
            Console.WriteLine("sum of "+ n1+" and "+ n2 + " is "+ sum);   /*concatenation method*/


            Console.ReadLine();

        }
    }
}
