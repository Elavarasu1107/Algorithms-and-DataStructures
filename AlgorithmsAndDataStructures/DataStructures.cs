using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class DataStructures
    {
        public void UnorderedList()
        {
            string input = System.IO.File.ReadAllText(@"D:\BridgeLabz\Algorithms-and-DataStructures\AlgorithmsAndDataStructures\InputString.txt");
            string[] arrayOfString = input.Split(',');
            Lists<string> list = new Lists<string>();
            foreach (string s in arrayOfString)
            {
                list.Append(s);
            }
            list.Display();
            Console.Write("Enter the word you want to search : ");
            string search = Console.ReadLine();
            list.Search(search);
            if (list.flag == 0)
            {
                Console.WriteLine("Adding " + search + " in the linked list\n");
                list.Append(search);
            }
            if (list.flag == 1)
            {
                list.DeleteValue(search);
            }
            list.Display();
        }
    }
}
