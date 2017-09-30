using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main(string[] args) // main function
        {
            Console.WriteLine("Sum of two ints is {0}", sum(45, 64)); /// 'sum' is defined as a method here, we need to look into sum's actual method definition following the main function to see what it actually does
                                                                     /// 
            Console.WriteLine("Sum of two ints is {0}", sum(45.45, 45.45)); // method overloading ... we can use sum function defined twice when data type is different, system is able to recognize
            Console.ReadKey();
        }
        public static int sum(int x, int y) /// so here is when 'sum' is defined ... takes two argments ... integers X & Y
        {
            int add = x + y;    /// variable 'add' is the sum or x+y
            return add; /// return the value of 'add'... we use this 'return' feature because it's set to public static *int*, aka this method returns an int
        }
        public static double sum(double x, double y) /// same this here, this method will return a double; public static double
        {
            double add = x + y;
            return add;
        }
    }
}
