using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    internal class CALCULATOR
    {
        public static void Addition(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addition result of {0} and {1} is {2}", a,b,c); 
        }
        public static void Multiplication(int a, int b) 
        {
            int c = a * b;
            Console.WriteLine("Multiplication result of {0} and {1} is {2}", a, b, c); 
        }
        public static void Substraction(int a, int b) 
        {
            int c = a - b;
            Console.WriteLine("Substraction result of {0} and {1} is {2}", a, b, c);
        }
        public static void Division(int a, int b) 
        {
            int c = a / b;
            Console.WriteLine("Division result of {0} and {1} is {2}", a, b, c);
        }
        static void Main0(string[] args)
        {
            
            while(true)
            {

                Console.WriteLine("Enter first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Operator (+,-,*,/)");
                string op = Console.ReadLine();



                if (op == "+")
                {
                    CALCULATOR.Addition(num1, num2);
                }
                else if (op == "-")
                {
                    CALCULATOR.Substraction(num1, num2);
                }
                else if (op == "*")
                {
                    CALCULATOR.Multiplication(num1, num2);
                }
                else if (op == "/")
                {
                    CALCULATOR.Division(num1, num2);
                }
                else
                {
                    Console.WriteLine("Invalid operation");
                }

                Console.WriteLine("Do you want to continue the program?");
                string n = Console.ReadLine().ToLower();
                if(n =="yes")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }
            
        }
       
    }
}
