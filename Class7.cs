using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class7
    {
        static int divide(int a, int b)
        {
            return a / b;

        }

        static int multiply(int a,int b)
        {
            return a * b;
        }

        static int sum(int a,int b)
        {
            return a+b;
        }

        static int sub(int a,int b)
        {
            return a - b;
        }

        static int mod(int a, int b)
        {
            return a % b;
        }
        public static void Main_()
        {
            int a;
            int b;
            Console.WriteLine("Input the First Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2} ", a, b, sum(a, b));
            Console.WriteLine("{0} - {1} = {2} ", a, b, sub(a, b));
            Console.WriteLine("{0} * {1} = {2} ", a, b, multiply(a, b));
            Console.WriteLine("{0} / {1} = {2} ", a, b, divide(a, b));
            Console.WriteLine("{0} mod {1} = {2} ", a, b, mod(a, b));

            Console.ReadKey();
        }
    }
}
