using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 45, b = 67; ;
            int sum = 0; // initializing the sum at 0
            int prod = 0; //initializing the product at 0    (product of multiplying a & B)
            MyCalc(a,b, out sum, out prod);

            Console.WriteLine("Sum of {2} + {3} = {0} and Product of {2} * {3}  ={1}", sum, prod,a,b);

            Console.ReadKey();
        }

        public static void MyCalc(int x, int y, out int sum, out int prod) /// replaced void with int because we are returning the value from the variable add (add = x+y)
        {
             sum = x + y;
            prod = x * y;

        }
    }
}
