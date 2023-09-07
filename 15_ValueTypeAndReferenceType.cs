using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{

    ////VALUE TYPE ---- STRUCT ---- STACK MEMORY . It will hold the data value within its own memory space
    //struct Employee
    //{
    //    public int Salary;
    //    public int Age;
    //}
    //class ValueTypeAndReferenceType
    //{
    //    static void Main(string[] args)
    //    { 
    //        Employee e = new Employee();
    //        e.Salary = 5000;
    //        e.Age = 23;

    //        Employee e1 = e;
    //        Employee e2 = e;

    //        e.Age = 25;

    //        Console.WriteLine(e1.Age);
    //        Console.WriteLine(e2.Age);
    //        Console.WriteLine(e.Age);


    //        Console.ReadLine();

    //    }
    //}

    //REFERENCE TYPE ---- CLASS ---- HEAP MEMORY . reference type doesn't store its value directly . it store the address where the value is being stored 
    class Employee
    {
        public int Salary;
        public int Age;
    }
    class ValueTypeAndReferenceType
    {
        static void Main15(string[] args)
        {
            Employee e = new Employee();
            e.Salary = 5000;
            e.Age = 23;

            Employee e1 = e;
            Employee e2 = e;

            e.Age = 25;

            Console.WriteLine(e1.Age);
            Console.WriteLine(e2.Age);
            Console.WriteLine(e.Age);


            Console.ReadLine();

        }
    }

}
