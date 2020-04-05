using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\log.txt", true))
            {
                file.WriteLine(number);
            }
            string text = File.ReadAllText(@"C:\log.txt");
            Console.WriteLine(text);
            Console.ReadLine();

        }
    }
}
