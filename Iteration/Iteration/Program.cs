using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "Apple ", "Banana ", "Orange ", "Kiwi " };
            Console.WriteLine("Enter some text");
            string text = Console.ReadLine();
            for (int i=0; i<myArray.Length; i++)
            {
                myArray[i] = myArray[i]+text;
;               Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();

            int j = 0;
            do
            {
                Console.WriteLine("Value of j: {0}", j);
                j++;
            } while (j <= 5);
            Console.ReadLine();

            List<string> myList = new List<string>() { "apple", "banana", "orange", "pear", "mango" };
            Console.WriteLine("Can you guess which fruit is in the list?");
            string text2 = Console.ReadLine();         
            foreach (string fruit in myList)
            {
                if (fruit == text2)
                {
                    int index = myList.IndexOf(fruit);
                    Console.WriteLine(index);
                    break;
                }
            }
            while (!myList.Contains(text2))
            {
                Console.WriteLine("Nope, try again.");
                text2 = Console.ReadLine();
                foreach (string fruit in myList)
                {
                    if (fruit == text2)
                    {
                        int index = myList.IndexOf(fruit);
                        Console.WriteLine(index);
                        break;
                    }
                }
            }
            Console.ReadLine();


            List<string> myList2 = new List<string>() { "apple", "banana", "mango", "orange", "pear", "mango", "plum" };
            List<string> myList3 = new List<string>();
            foreach (string item in myList2)
            {
                if (myList3.Contains(item))
                {
                    Console.WriteLine("The {0} already occured", item);

                }
                else
                {
                    Console.WriteLine("The {0} appears for the first time", item);
                    myList3.Add(item);
                }
            }
            Console.ReadLine();
        }
    }
}
