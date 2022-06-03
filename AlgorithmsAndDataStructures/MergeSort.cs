using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class MergeSort
    {
        public void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] temp1 = new int[n1];
            int[] temp2 = new int[n2];
            int i, j;

            for (i = 0; i < n1; i++)
            {
                temp1[i] = array[left + i];
            }
            for (j = 0; j < n2; j++)
            {
                temp2[j] = array[middle + 1 + j];
            }
            int k = left;
            i = 0;
            j = 0;

            while (i < n1 && j < n2)
            {
                if (temp1[i] <= temp2[j])
                {
                    array[k] = temp1[i];
                    i++;
                }
                else
                {
                    array[k] = temp2[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                array[k] = temp1[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                array[k] = temp2[j];
                j++;
                k++;
            }
        }
        public void sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                sort(array, left, middle);
                sort(array, 1 + middle, right);

                Merge(array, left, middle, right);
            }
        }
        public void Print(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}

