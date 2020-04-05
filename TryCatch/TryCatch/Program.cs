using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int> {2, 4, 6, 8, 10, 12, 3, 5, 7, 9};
            
            try
            {
                Console.WriteLine("Please enter a number");
                int num = Convert.ToInt32(Console.ReadLine());
                foreach (int number in myList)
                {
                    int result = number / num;
                    Console.WriteLine("The item in a list divided by your number equals " + result);
                }
            }
            catch (FormatException ex)
            {
                    Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The program is done with the try/catch block and moving on to the next instruction...");
                Console.ReadLine();
            }
        }
    }
}
