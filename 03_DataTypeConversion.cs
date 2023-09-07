using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    class DataTypeConversion
    {
        static void Main3(string[] args)
        {

            string a = "50";

            int b = int.Parse(a);
            float f = float.Parse(a);

            int c = Convert.ToInt32(a);
            float d = 20.123f;
            int e = (int) d;

            Console.WriteLine("Enter 1st number");
            float g = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            float h = float.Parse(Console.ReadLine());
            float i = h + g;
            Console.WriteLine(i); 

            Console.ReadLine();

        }
    }
}
