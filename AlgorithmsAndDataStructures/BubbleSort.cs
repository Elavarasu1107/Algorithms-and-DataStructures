using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class BubbleSort
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Before Sorting");
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(array[k] + " ");
            }
            Console.WriteLine("\nAfter Sorting");
            int i = 0, temp;
            while (i < array.Length - 1)
            {
                int j = 0;
                while (j < array.Length - (i + 1))
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                    j++;
                }
                i++;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
