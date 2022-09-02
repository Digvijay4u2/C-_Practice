using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class5
    {
        static void swap(int a,int b)
        {
            int c = b;
            b = a;
            a = c;

            Console.WriteLine("After swapping  :\nFirst Number : {0}\nSecond Number : {1}",a,b);

        }
        public static void Main_()
        {
            int a;
            int b;
            Console.WriteLine("Input the First Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());

            swap(a, b);

            Console.ReadKey();
        }
    }
}
