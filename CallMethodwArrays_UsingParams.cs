using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[5];
            myArray[0] = "name0";
            myArray[1] = "name1";
            myArray[2] = "name2";
            myArray[3] = "name3";
            myArray[4] = "name4";

            ArrayMethod(myArray);
            Console.ReadKey();
        }
        public static void ArrayMethod(params string[] names)
        {
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Array Size = {0}", names.Length);
        }
    }
}
