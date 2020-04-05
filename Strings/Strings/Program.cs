using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            string first = "My name is ";
            string name = "Dana ";
            string lname = "Badmaeva";
            string result = first + name + lname;
            Console.WriteLine(result);
            Console.ReadLine();

            name = name.ToUpper();
            lname = lname.ToUpper();
            result = first + name + lname;
            Console.WriteLine(result);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("This is a C# course ");
            sb.Append("at the Tech Academy! ");
            sb.Append("Learning to work with strings.");
            sb.Append("Strings are immutable.");
            sb.Append("StringBuider is a mutable string class.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
