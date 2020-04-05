using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            int result;
            MathOperation.BasicMath(number, out result);
            Console.WriteLine(result);

            int a = 50;
            int b = 60;
            Console.WriteLine("{0}, {1}", a, b);

            MathOperation.BasicMath2(out a, out b);
            Console.WriteLine("{0}, {1}", a, b);

            Console.ReadLine();

        }
    }
}
