using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    internal class Switch
    {
        static void Main8(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            switch (name) 
            {
                case "Ali":
                    Console.WriteLine("Welcome {0}",name); 
                    break;
                case "Sandra":
                    Console.WriteLine("Welcome {0}", name);
                    break;
                case "Khan":
                    Console.WriteLine("Welcome {0}", name);
                    break;
                case "Leelu":
                    Console.WriteLine("Welcome {0}", name);
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;

            }

            //showing some cases doesn't need statement when it can print the same statement of next case

            Console.WriteLine("Age");
            int age = int.Parse(Console.ReadLine());

            switch (age) 
            {
                case 15:
                case 16:
                case 17:
                    Console.WriteLine("You are not eligible to vote");
                    break;
                case 18:
                case 19:
                    Console.WriteLine("You are eligible for voting");
                    break;
                default: Console.WriteLine("Invalid age");
                break;
            
            
            }

            // NESTED SWITCH STATEMENT

            Console.WriteLine("Enter your Pizza flavour");
            string pizza = (Console.ReadLine());

            switch (pizza)
            {
                case "Cheese":
                    Console.WriteLine("You have selected {0} pizza", pizza);
                    break;
                case "Veg":
                    Console.WriteLine("Enter your Veg Pizza flavour");
                    string veg = (Console.ReadLine());
                    switch (veg)
                    {
                        case "Olive":
                            Console.WriteLine("You have selected {0} {1} pizza", veg,pizza);
                            break;
                        case "Cheese":
                            Console.WriteLine("You have selected {0} {1} pizza", veg, pizza);
                            break;
                        default : Console.WriteLine("Vegetable not available");
                            break;
               
                    }
                    break;

                case "Supreme":
                    Console.WriteLine("You have selected {0} pizza", pizza);
                    break;
                default :
                    Console.WriteLine("Invalid pizza flavour");
                    break;




            }

                Console.ReadLine();
        }
    }
}
