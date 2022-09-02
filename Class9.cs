using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class9 
    {
        static int average(int a, int b,int c,int d)
        {
            return (a + b + c + d) / 4;

        }
        public static void Main_()
        {
            int a;
            int b;
            int c; int d;
            Console.WriteLine("Input the First Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Third Number : ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Fourth Number : ");
            d = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("The average of {0} , {1} , {2} , {3} is : {4}",a,b,c,d, average(a, b,c,d));

            Console.ReadKey();
        }
    }
}
