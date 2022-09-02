using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class8
    {
        static void Table(int a)
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
            }

        }
        public static void Main_()
        {
            int a;
            
            Console.WriteLine("Input the  Number : ");
            a = Convert.ToInt32(Console.ReadLine());


            Table(a);

            Console.ReadKey();
        }
    }
}
