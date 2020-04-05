using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();
            Console.WriteLine("Enter the First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number. The Second Number is optional, you can leave it blank.");
            string userInput2 = Console.ReadLine();
            if (userInput2 =="")
            {
                int result1 = mathOperation.BasicMath(num1);
                Console.WriteLine("(Your FirstNumber + 100) equals: " + result1);
            }
            else
            {
                int num2 = Convert.ToInt32(userInput2);
                int result2 = mathOperation.BasicMath(num1, num2);
                Console.WriteLine("(Your FirstNumber + 100) * your SecondNumber equals: " + result2);
            }
            
            Console.ReadLine();
            
        }
    }
}
