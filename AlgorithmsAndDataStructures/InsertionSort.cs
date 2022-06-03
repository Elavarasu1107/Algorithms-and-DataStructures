using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class InsertionSort
    {
        public void Sort()
        {
            string inputString = System.IO.File.ReadAllText(@"D:\BridgeLabz\Algorithms-and-DataStructures\AlgorithmsAndDataStructures\InputInteger.txt");
            string[] arrayOfString = inputString.Split(',');
            int[] array = arrayOfString.Select(int.Parse).ToArray();
            Console.WriteLine("Before Sorting");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            int j;
            Console.WriteLine("\nAfter Sorting");
            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                for (j = i - 1; j >= 0 && array[j] > temp; j--)
                {
                    array[j + 1] = array[j];
                }
                array[j + 1] = temp;
            }
            Console.Write(String.Join(" ", array));
        }
    }
}
