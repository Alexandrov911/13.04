using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Александров1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            if ( (a < b + c) & (b < a + c) & (c < a + b))
            {
                Console.WriteLine("существует");
            }
            else
            {
                Console.WriteLine("не существует");

            }
            Console.ReadKey();

       
        }
    }
}
