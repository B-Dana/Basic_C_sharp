using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOverload
{
    public class MathOperation
    {
        public int BasicMath(int num)
        {
            int result = num * 100 / 2;
            return result;
        }

        public int BasicMath(decimal dec)
        {
            int result = Convert.ToInt32((dec + 100) / 2);
            return result;
        }

        public int BasicMath(string number)
        {
            int result = Convert.ToInt32(number) / 10;
            return result;
        }
    }
}
