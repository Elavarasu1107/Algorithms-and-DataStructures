using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class PermutationOfString
    {
        public void Permutation(string inputString, string store)
        {
            if (inputString.Length == 0)
            {
                Console.Write(store + " ");
                return;
            }
            for (int i = 0; i < inputString.Length; i++)
            {
                char chars = inputString[i];
                string subString1 = inputString.Substring(0, i);
                string subString2 = inputString.Substring(i + 1);
                string result = subString1 + subString2;
                Permutation(result, store + chars);
            }
        }
        public void Main()
        {
            String store = "";

            Console.Write("Enter the string : ");
            string inputString = Console.ReadLine();

            Permutation(inputString, store);
            Console.WriteLine();
        }
    }
}
