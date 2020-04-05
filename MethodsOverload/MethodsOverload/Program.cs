using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOverload
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            MathOperation mathOperation = new MathOperation();
            int result1 = mathOperation.BasicMath(num1);
            Console.WriteLine("Your number * 100 /2 equals: " + result1);

            Console.WriteLine("Enter a decimal");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            int result2 = mathOperation.BasicMath(num2);
            Console.WriteLine("(Your decimal + 100 )/2 equals: " + result2);

            Console.WriteLine("Enter a number");
            string num3 = Console.ReadLine();
            int result3 = mathOperation.BasicMath(num3);
            Console.WriteLine("Your number / 10 equals: " + result3);

            Console.ReadLine();




        }
    }
}
