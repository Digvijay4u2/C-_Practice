using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class2
    {
       static void sum(int a,int b)
        {
            Console.WriteLine("Result after adding a and b is : {0} ",a + b);
        }

        public static void Main_()
        {
            int a;
            int b;
            Console.WriteLine("Enter value of a and b : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            sum(a, b);

            Console.ReadKey();
        }

    }
}
