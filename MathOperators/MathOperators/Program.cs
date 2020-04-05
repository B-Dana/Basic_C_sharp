using System;

namespace MathOperators
{
    class Program
    {
        static void Main()
        {
            string num1 = Console.ReadLine();
            int myNum1= Convert.ToInt32(num1);
            int product = myNum1 * 50;
            Console.WriteLine("Your number * 50 is "+ product);
           
            string num2 = Console.ReadLine();
            int myNum2 = Convert.ToInt32(num2);
            int sum = myNum2 + 25;
            Console.WriteLine("Your number + 25 is " + sum);

            string num3 = Console.ReadLine();
            double myNum3 = Convert.ToDouble(num3);
            double quotient = myNum3 / 12.5;
            Console.WriteLine("Your number / 12.5 is " + quotient);

            string num4 = Console.ReadLine();
            int myNum4= Convert.ToInt32(num4);
            bool result = myNum4 > 50;
            Console.WriteLine("Check if your number is > than 50: " + result );

            string num5 = Console.ReadLine();
            int myNum5 = Convert.ToInt32(num5);
            int remainder = myNum5 % 7;
            Console.WriteLine("The remainder of: your number / 7 is: " + remainder);
            Console.Read();

        }
    }
}
