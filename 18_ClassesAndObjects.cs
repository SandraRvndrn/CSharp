using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Learnings
{
    class Student
    {
        int rollno;
        string name;
        int age;
        int standard; 

        public void setStudent(int rollno, string name, int age, int standard)
        {
            this.rollno = rollno; // this keyword will refer to properties of the class
            this.name = name;
            this.age = age;
            this.standard = standard;
        }
        public void getStudent()
        {
            Console.WriteLine("Your Roll No is: {0}",this.rollno );
            Console.WriteLine("Your Name is: {0}",this.name);
            Console.WriteLine("Your Age is: {0}",this.age);
            Console.WriteLine("Your Standard is: {0}",this.standard);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Roll no : ");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name : ");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your standard : ");
            int standard = int.Parse(Console.ReadLine());



            Student Sandra = new Student();
            Sandra.setStudent(rollno, name, age, standard);
            Sandra.getStudent();

            Console.ReadLine();
        }


    }

    
}
