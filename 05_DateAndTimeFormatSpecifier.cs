 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    class DateAndTimeFormatSpecifier

    {
        static void Main5(string[] args)
        {

            DateTime dt = DateTime.Now;
            Console.WriteLine("{0:d}", dt);
            Console.WriteLine("{0:D}", dt);
            Console.WriteLine("{0:f}", dt);
            Console.WriteLine("{0:F}", dt);
            Console.WriteLine("{0:g}", dt);

            Console.WriteLine("{0:d} {1:D}", dt, dt);

            Console.WriteLine("{0:G}", dt);
            Console.WriteLine("{0:m}", dt);
            Console.WriteLine("{0:t}", dt);
            Console.WriteLine("{0:T}", dt);
            Console.WriteLine("{0:y}", dt);
            Console.WriteLine("{0:yy}", dt);
            Console.WriteLine("{0:yyyy}", dt);

            Console.WriteLine("{0:ddd}", dt);
            Console.WriteLine("{0:dddd}", dt);
            Console.WriteLine("{0:FF}", dt);
            Console.WriteLine("{0:HH}", dt);
            Console.WriteLine("{0:MM}", dt);
            Console.WriteLine("{0:MMM}", dt);
            Console.WriteLine("{0:ss}", dt);

            Console.WriteLine("{0:hh:mm:ss tt }", dt); //tt stands for am or pm
            Console.WriteLine("{0:dd-MM-yyyy }", dt);

            Console.ReadLine();

        }
    }
}
