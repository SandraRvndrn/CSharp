using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    class Class1
    {
        static void Main7(string[] args)
        {

            //IF ELSE
            Console.WriteLine("Enter your name");
            string a = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string b = Console.ReadLine();

            if (a == "Sandra" && b == "Lee123")
            {

                Console.WriteLine("Hi Lilo");

            }
            else
            {

                Console.WriteLine("Incorrect password or name");

            }


            //IF, ELSE IF

            Console.WriteLine("Enter your percentage :  ");
            int percentage = int.Parse(Console.ReadLine());

            if (percentage >= 90) 
            {
            Console.WriteLine("Grdae : A");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Grade : B");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Grade : C");
            }
            else 
            {
                Console.WriteLine("Failed");
            }


            //NESTED IF

            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();

            if ( email == "sandra@gmail.com")
            {
                Console.WriteLine("Enter your password");
                string pass = Console.ReadLine();
                if (pass == "Lee*123")
                {

                    Console.WriteLine("Login Succesfull");
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Email");
            }


            Console.ReadLine();
        }

    }
}
