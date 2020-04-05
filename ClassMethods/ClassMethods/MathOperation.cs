using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    public static class MathOperation
    {
        public static void BasicMath(int num, out int result)
        {
            result = num / 2;
           
        }
        public static void BasicMath2(out int num1, out int num2)
        {
            num1 = 10;
            num2 = 15;
        }

        public static void BasicMath2(out int num1, out int num2, int num3)
        {
            num1 = 20;
            num2 = 30;
            int result = num3 * 150;
        }
    }
}
