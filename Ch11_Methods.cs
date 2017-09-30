using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class ExampleOne
    {
        static void Main(string[] args)
        {
            ExampleOne eOne = new ExampleOne(); // this is an object, or an instance
            eOne.sum();     /// here is where we are calling our method 'sum', creating an instance of it
                            /// we are calling the sum method in our main function
            eOne.sum();
            eOne.sum();
            Console.ReadKey();

            Console.ReadKey();

        }
        public void sum()   /// here is where we are defining our method
                            /// void = return type ... so when we see return type = void, that means our method is not returning anything
        {
            int no1 = 364, no2 = 234;
            int add = no1 + no2;
            Console.WriteLine("Addition\t\t{0}", add);
        }

    }
}
