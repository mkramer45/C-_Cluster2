using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Box
    {
        public double h, l, w; /// public, we can use this variable in other classes ... length, height, width ..
                               /// access specifier can be public, private, protected
        public double volume(double l, double w, double h)
        {
            return (l * w * h);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(); /// this is the instance of the class in our main method
            box1.l = 45;
            box1.w = 10;
            box1.h = 20; /// by defining variable values down here, we are 'initializing the values of our box class'

            Console.WriteLine("Volume of box1 is {0}", box1.volume(box1.l, box1.w, box1.h));

            Console.ReadKey();
        }
    }
}
