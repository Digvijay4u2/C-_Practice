using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class3
    {
        static void divide(Double a,Double b)
        {
            if(b==0)
            {
                Console.WriteLine("Denominator can't be zero.");
            }
            else
            {
                Console.Write("Result of dividing {0} by {1} is : {2} ", a, b, a / b);
            }

        }
        public static void Main_()
        {
            Double a;
            Double b;
            Console.WriteLine("Enter value of a and b : ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

            divide(a, b);

            Console.ReadKey();
        }
    }
}
