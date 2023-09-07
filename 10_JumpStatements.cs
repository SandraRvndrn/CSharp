using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    internal class JumpStatements
    {
        static void Main10 (string[] args)
        {
             /*here are 4 type of jump statement
               1) Break
               2) Continue
               3) go to
               4) return
             jump statement are used in selection  and loop constructs  
              
             */

            //Break 
            for (int i = 0; i <10; i++)
            {
                if(i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            //Continue
            for (int i = 0; i < 10; i++)
            {
                if (i%2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            //go to
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    goto stop; 
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("bye"); //It won't get printed bcos of using goto statement . it skipped the statements inbtw goto and stop.

        stop:
            Console.WriteLine("program got terninated");

            Console.ReadLine();
        }


    }
}
