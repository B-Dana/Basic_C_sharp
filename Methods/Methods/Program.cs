using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            MathClass mathClass = new MathClass();
            int result1 = mathClass.MathOperation1(num);
            Console.WriteLine("You number + 100 equals "+result1);

            int result2 = mathClass.MathOperation2(num);
            Console.WriteLine("You number * 100 equals " + result2);

            int result3 = mathClass.MathOperation3(num);
            Console.WriteLine("You number / 2 equals " + result3);

            Console.ReadLine();

        }
    }
}
