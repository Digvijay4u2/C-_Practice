using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class10
    {
        static int firstExp(int a, int b, int c)
        {

            return (a + b) * c;

        }
        static int secondExp(int a, int b, int c)
        {

            return a*b + b*c;

        }
        public static void Main_()
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Input the First Number  : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number  : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Third Number  : ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3} and x.y +y.z is {4}", a, b, c, firstExp(a, b, c), secondExp(a, b, c));

            Console.ReadKey();
        }
    }
}
