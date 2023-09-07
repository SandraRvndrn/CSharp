using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Learnings
{
    internal class MainOrFunction
    {
        public  void show() //declaring a method / Non-static method / instance method / Non-parameterized method
        {
            Console.WriteLine("Welcome to C#");
            Console.WriteLine("Hi");
        }
        public static void show1() //declaring a method / static method / Non-parameterized method
        {
            Console.WriteLine("Hi hello how are you!!!!"); 
        }
        public static void add(int a, int b) //declaring a method / static method / parameterized method
        {     
          int c = a + b;
          Console.WriteLine(c);
        }
        public static void showname(string a = "UNKNOWN") //declaring a method / static method / parameterized method 
        {
            Console.WriteLine("Hi {0}", a);
        }
        public static void Show_Name_Age(string Name, int Age)
        {
            Console.WriteLine("Your Name is {0}", Name);
            Console.WriteLine("Your Age is {0}", Age);
        }
        public static int ad(int a, int b) //declaring a method / static method / parameterized method
        {
            int c = a + b;
            return c;
        }

        static void Main14()
        {
            MainOrFunction a = new MainOrFunction();
            a.show(); //calling the non-static method , for calling a non-static method we need to creat an object and then call the method with object name
            a.show();
            a.show();

            MainOrFunction.show1 (); //calling the static method , for calling a static method we don't need to creat an object.We can just call it by using the class name.method name

            MainOrFunction.add(1, 2); // 1 AND 2 IS ARGUMENTS
            Console.WriteLine("Enter 1st no.");  
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no.");
            int e = int.Parse(Console.ReadLine());
            MainOrFunction.add(d, e);

            MainOrFunction.showname("Sandra");
            MainOrFunction.showname();

            MainOrFunction.Show_Name_Age("Sandra", 24);
            MainOrFunction.Show_Name_Age(Age: 24, Name: "Sandra"); // named arguments

            Console.WriteLine(MainOrFunction.ad(1, 2)); // method calling
            int f = MainOrFunction.ad(1, 2);
            Console.WriteLine(f);


            Console.ReadLine(); 
        } 
        
    }
}
