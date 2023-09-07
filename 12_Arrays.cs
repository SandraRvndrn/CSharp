using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    internal class Arrays
    {
        static void Main12(string[] args)
        {
            ////there are two type of array ( single dim and multi dimentional array)
            ////SINGLE DIMENTIONAL ARRAY
            //int[] Array = new int[2];
            //Array[0] = 1;
            //Array[1] = 1;
            //Console.WriteLine(Array[0]);
            //Console.WriteLine(Array[1]);

            //int[] Array1 = { 2, 2, 2, 2, 2 };
            //Console.WriteLine(Array1[0]);
            //Console.WriteLine(Array1[1]);
            //Console.WriteLine(Array1[2]);
            //Console.WriteLine(Array1[3]);
            //Console.WriteLine(Array1[4]);

            //int[] ARRAY2 = new int[3] { 3, 3, 3 };
            //Console.WriteLine(ARRAY2[0]);
            //Console.WriteLine(ARRAY2[1]);
            //Console.WriteLine(ARRAY2[2]);

            //String[] Array2 = { "Sandra", "Khan", "Leelu" };
            //Console.WriteLine(Array2[0]);  
            //Console.WriteLine(Array2[1]);
            //Console.WriteLine(Array2[2]);

            Console.WriteLine("How many number of items you want to store in this array?");
            int a =int.Parse(Console.ReadLine());

            int[] n = new int[a];
            Console.WriteLine("Enter the {0} number",a);
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numbers you stored is ");
           foreach (int i in n)
            {
                Console.WriteLine(i);
            }

            ////MULTY DIMENTIONAL ARRAY
            //// there are 2 type of multi dimentional array (ractangular array and jagged array)
            //// 1. RECTANGULAR ARRAY
            //int[,] array = new int[3, 4]
            //{
            //    { 1,1,1,1},
            //    { 2,2,2,2},
            //    { 3,3,3,3}     
            //};

            ////to get the length of raws in array 
            //Console.WriteLine(array.GetLength(0));
            ////to get the length of columns in array  
            //Console.WriteLine(array.GetLength(1));
            ////to get the dimention of an array
            //Console.WriteLine(array.Rank);
            //Console.WriteLine("\n");

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for(int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine("\n");
            //}

            //2. JAGGED ARRAY

            //int[][] ar = new int[4][];
            //  ar[0] = new[] { 1, 1, 1, 1 };
            //  ar[1] = new[] { 2,2 };
            //  ar[2] = new[] { 3,3,3,3,3,3 };
            //  ar[3] = new[] { 4,4};

            //foreach (int[] i in ar)
            //{
            //    foreach (int x in i)
            //    {
            //        Console.Write(x + " ");
            //    }
            //    Console.WriteLine("\n");
            //}
            
            //for (int i = 0; i < ar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ar[i].GetLength(0); j++)
            //    {
            //        Console.Write(ar[i][j]);
            //    }
            //    Console.WriteLine("\n");
            //}
            Console.ReadLine();
        }
    }
}
 