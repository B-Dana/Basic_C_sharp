using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();
            int number1 = 50;
            int number2 = 125;
            mathOperation.BasicMath(num1: number1, num2: number2);
            Console.ReadLine();
        }
    }
}
