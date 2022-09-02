using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class6
    {
        static void Multiply(int a, int b,int c)
        {
            

            Console.WriteLine("{0} * {1} * {2} = {3}", a, b,c,a*b*c);

        }
        public static void Main_()
        {
            int a;
            int b;
            int c;
            
            Console.WriteLine("Input the First Number to multiply : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number to multiply : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Third Number to multiply : ");
            c = Convert.ToInt32(Console.ReadLine());

            Multiply(a, b,c);

            Console.ReadKey();
        }
    }
}
