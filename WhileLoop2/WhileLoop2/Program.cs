using System;


namespace WhileLoop
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Value of i: {0}", i);
                i++;
            }
            Console.ReadLine();


            int n = 0;
            do
            {
                Console.WriteLine("Value of n: {0}", n);
                n++;
            }
            while (n < 10);
            Console.ReadLine();
        }
    }
}

