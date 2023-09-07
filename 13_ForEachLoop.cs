using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    internal class ForEachLoop
    {
        static void Main13(string[] args)
        {
            //FOR EACH LOOP FOR SINGLE DIMENTIONAL ARRAY
            int[] n = new int[10];

            Console.WriteLine("Enter the 10 number");   

            for (int i = 0; i < n.Length; i++)  
            {
                 n[i] =  int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Numbers you stored is "); 

            foreach (int i in n)
            {
                Console.WriteLine(i);
            }

            //FOR EACH LOOP FOR MULTI DIMENTIONAL ARRAY (JAGGED ARRAY)
            int[][] ar = new int[4][];
            ar[0] = new[] { 1, 1, 1, 1 };
            ar[1] = new[] { 2, 2 };
            ar[2] = new[] { 3, 3, 3, 3, 3, 3 };
            ar[3] = new[] { 4, 4 };

            foreach (int[] i in ar)
            {
                foreach (int x in i)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
