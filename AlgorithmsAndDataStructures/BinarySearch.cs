using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class BinarySearch
    {
        public void Main()
        {
            string input = System.IO.File.ReadAllText(@"D:\BridgeLabz\Algorithms-and-DataStructures\AlgorithmsAndDataStructures\InputString.txt");
            string[] arrayOfString = input.Split(',');
            Array.Sort(arrayOfString);
            Console.WriteLine("Sorted Array is:");
            for (int i = 0; i < arrayOfString.Length; i++)
            {
                Console.Write(arrayOfString[i] + ",");
            }
            Console.WriteLine("\nEnter a word to search the file");
            string userInput = Console.ReadLine();
            int output = StringSearch(arrayOfString, 0, arrayOfString.Length - 1, userInput);

            if (output == -1)
            {
                Console.WriteLine("Data not found in the file");
            }
            else
            {
                Console.WriteLine(userInput + " is at index " + output);
            }
        }
        public int StringSearch(string[] array, int left, int right, string userInput)
        {
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                int result = userInput.CompareTo(array[middle]);
                if (result == 0)
                {
                    return middle;
                }
                if (result > 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }
    }
}
