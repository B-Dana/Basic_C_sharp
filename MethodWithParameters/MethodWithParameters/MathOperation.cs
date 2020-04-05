using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithParameters
{
    public class MathOperation
    {

        public int BasicMath(int num1, int num2=1)
        {
            int result = num1 + 100;
            result = result * num2;
            return result;

        }
    }
}
