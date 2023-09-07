using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    class DataTypes
    {
        static void Main2(string[] args)

        {
            //INTEGER DATA TYPE

            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(ulong.MaxValue);

            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(char.MinValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(ulong.MinValue);

            

            // BOOLEAN DATA TYPE
            int a = 30;
            int b = 31;
            bool c = a > b;
            Console.WriteLine(c);

            // FLOAT DOUBLE AND DECIMAL DATA TYPE

            float d = 121323.343f;
            double e = 13243425.2d;
            decimal f = 213138.3m;

            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            // STRING AND CHARACTER DATA TYPE

            String g = "D:\\sandra\\csharp\\tutorial"; /*using escape sequences*/ /*less readable*/
            String i = @"D:\sandra\csharp\tutorial";  /*using verbatim literal*/ /*more readable*/
            char h = 'a';
            Console.WriteLine(g);
            Console.WriteLine(i);
            Console.WriteLine(h);


            Console.ReadLine();




        }
    }
}
