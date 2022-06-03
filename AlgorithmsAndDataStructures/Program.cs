using System;

namespace AlgorithmsAndDataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Permutation of String\n 2 for BinarySearch");
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
                default:
                    {
                        Console.WriteLine("Enter a Valid Number");
                        break;
                    }
            }
        }
    }
}
