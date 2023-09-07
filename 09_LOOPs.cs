using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    internal class LOOP
    {
        static void Main9(string[] args)
        {
            Console.WriteLine("Enter any number to see the multiplication table of it");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("the muiltiplication table is");

            //FOR LOOP

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("{0} X {1} = ", a, i);
            //    Console.WriteLine(a * i);
            //}
            ////WHILE LOOP

            //int b = 1;
            //while (b <= 10)
            //{
            //    Console.WriteLine(b + "X" + a + "=" + b * a);
            //    b++;
            //}

            ////DO WHILE

            //int i = 0;

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i <= 10);

            ////NESTED FOR LOOP

            //for (int i =1; i <=3;i++)
            //{
            //    Console.WriteLine("hi");
            //    for(int j = 1; j <=3;j++)
            //    {
            //        Console.WriteLine("hello");
            //    }
            //}

            

            Console.ReadLine();

        }
    }
}
