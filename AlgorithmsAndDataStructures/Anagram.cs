using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class Anagram
    {
        public void Detector()
        {
            Console.WriteLine("Enter first String");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Enter second String");
            string userInput2 = Console.ReadLine();

            char[] array1 = userInput1.ToLower().ToCharArray();
            char[] array2 = userInput2.ToLower().ToCharArray();
            Array.Sort(array1);
            Array.Sort(array2);

            string string1 = new string(array1);
            string string2 = new string(array2);

            if (string1 == string2)
            {
                Console.WriteLine("Both Strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Strings are not Anagrams");
            }
        }
    }
}
