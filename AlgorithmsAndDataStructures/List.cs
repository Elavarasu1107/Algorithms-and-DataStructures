using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class Node<T> where T : IComparable
    {
        public T data;
        public Node<T> next;

        public Node(T data)
        {
            this.data = data;
        }
    }
    internal class Lists<T> where T : IComparable
    {
        public int flag = 0;
        public Node<T> head;
        public void Append(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> tempHead = head;
                while (tempHead.next != null)
                {
                    tempHead = tempHead.next;
                }
                tempHead.next = node;
            }
        }
        internal void DeleteValue(T search)
        {
            Node<T> tempHead = head;

            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (tempHead.next != null)
            {
                if (tempHead.next.data.CompareTo(search) == 0)
                {
                    tempHead.next = tempHead.next.next;

                }
                tempHead = tempHead.next;
            }
            Console.WriteLine("Data " + search + " is deleted from the list");
        }
        internal void Search(T search)
        {
            Node<T> tempHead = head;

            if (tempHead == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                while (tempHead.next != null)
                {
                    if (tempHead.data.CompareTo(search) == 0)
                    {
                        flag = 1;
                        Console.WriteLine("The Data " + search + " is present in the linked list");
                        return;
                    }
                    tempHead = tempHead.next;
                }
                if (flag == 0)
                {
                    Console.WriteLine("The Data " + search + " is not present in the linked list");
                    return;
                }
            }
        }
        internal void OrderedList(T data)
        {
            Node<T> newNode = new Node<T>(data);
            Node<T> tempHead = head;

            if (head == null || head.data.CompareTo(newNode.data) >= 0)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                while (tempHead.next != null && tempHead.next.data.CompareTo(newNode.data) < 0)
                {
                    tempHead = tempHead.next;
                }
                newNode.next = tempHead.next;
                tempHead.next = newNode;
            }
        }
        internal void Display()
        {
            Node<T> tempHead = head;

            if (tempHead == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Console.WriteLine("\nData after sorting: ");
                while (tempHead != null)
                {
                    Console.Write(tempHead.data + " ");
                    tempHead = tempHead.next;
                }
                Console.WriteLine();
            }
        }
    }
}
