using System;

namespace AlgorithmsAndDataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Permutation of String\n 2 for BinarySearch\n 3 for Insertion Sort\n 4 for Bubble Sort\n 5 for Merge Sort\n 6 for Anagram Checking\n" +
                " 7 for Unordered List\n 8 for Ordered List\n 9 for Balanced Parentheses");
            Console.WriteLine("Enter a Number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    {
                        PermutationOfString getMethod = new PermutationOfString();
                        getMethod.Main();
                        break;
                    }
                case 2:
                    {
                        BinarySearch getMethod = new BinarySearch();
                        getMethod.Main();
                        break;
                    }
                case 3:
                    {
                        InsertionSort getMethod = new InsertionSort();
                        getMethod.Sort();
                        break;
                    }
                case 4:
                    {
                        int[] array = { 30, 20, 50, 70, 120, 180, 100, 40 };
                        BubbleSort getMethod = new BubbleSort();
                        getMethod.Sort(array);
                        break;
                    }
                case 5:
                    {
                        int[] array = { 30, 20, 50, 70, 120, 180, 100, 40 };
                        MergeSort getMethod = new MergeSort();
                        Console.WriteLine("Before Sorting:");
                        getMethod.Print(array);
                        Console.WriteLine("\nAfter Sorting");
                        getMethod.sort(array, 0, array.Length - 1);
                        getMethod.Print(array);
                        break;
                    }
                case 6:
                    {
                        Anagram getMethod = new Anagram();
                        getMethod.Detector();
                        break;
                    }
                case 7:
                    {
                        DataStructures getMethod = new DataStructures();
                        getMethod.UnorderedList();
                        break;
                    }
                case 8:
                    {
                        DataStructures getMethod = new DataStructures();
                        getMethod.OrderedList();
                        break;
                    }
                case 9:
                    {
                        DataStructures getMethod = new DataStructures();
                        getMethod.BalanceChecker();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a Valid Number");
                        break;
                    }
            }
        }
    }
}
