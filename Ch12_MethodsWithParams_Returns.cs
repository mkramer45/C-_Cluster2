using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class ExampleOne
    {
        public static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            // Accepting Values From Users
            Console.Write("Enterfirst number\t\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nEnter second number\t\t");
            num2 = Convert.ToInt32(Console.ReadLine());


            ExampleOne eOne = new ExampleOne();
            int add = eOne.sum(num1, num2);
            Console.WriteLine("Addition\t\t{0}", add);
            Console.ReadKey();


        }
        public int sum(int no1, int no2)  /// int no1 & int no2 represent parameters for the sum function

        {
            int add = no1 + no2;
            return add;
            //Console.WriteLine("Addition\t\t{0}", add);
        }

    }
}
