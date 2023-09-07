using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    internal class RestartingProgramWithUserInput
    {
        static void Main11(string[] args)
        {
            // Will help us to restart or run the program again using while or do while


            //using WHILE LOOP
            
            while (true)
            {
                Console.WriteLine("Enter 1st number");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd number");
                int n2 = int.Parse(Console.ReadLine());
                int a = n1 + n2;
                Console.WriteLine("Sum of {0} and {1} is {2}", n1, n2, a);
                Console.WriteLine("Do you want to continue the sum function again?");
                string y = Console.ReadLine().ToLower();
                if (y == "yes") 
                {
                    continue;        
                }
                else
                {
                    break;
                }

            }

            //using DO WHILE LOOP

            //string y;

            //do
            //{
            //    Console.WriteLine("Enter 1st number");
            //    int n1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter 2nd number");
            //    int n2 = int.Parse(Console.ReadLine());
            //    int a = n1 + n2;
            //    Console.WriteLine("Sum of {0} and {1} is {2}", n1, n2, a);
            //    Console.WriteLine("Do you want to continue the sum function again?");
            //    y = Console.ReadLine().ToLower();

            //}

            //while (y == "yes");

            Console.WriteLine("Out of the loop");
            Console.ReadLine();

        }
    }
}
