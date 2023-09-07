using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    internal class MARKLIST
    {
        static void Main8(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the roll no.");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter physics mark");
            int phy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter maths marks");
            int ma = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter englid marks");
            int eng = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter chemistrty");
            int che = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter biology marks");
            int bio = int.Parse(Console.ReadLine());

            int obt = phy + ma + eng + che + bio;
            int p = obt * 100 / 500;

            Console.WriteLine("Obtained total mark is {0}", obt);
            Console.WriteLine("Percentage is {0}", p);

            if (p > 90)
            {
                Console.WriteLine("Grade A");
            }
            else if(p > 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (p > 60)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            int supply = 0;

            if (phy < 30) 
            {
                supply++;
            }
            if (ma < 30)
            {
                supply++;
            }

            Console.WriteLine("Supply you have is{0}",supply);
            Console.ReadLine();

        }
    }
}
