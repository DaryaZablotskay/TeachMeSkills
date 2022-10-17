using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyLinkedList<int>();
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(7);
            list.Add(9);

            Console.WriteLine(list.Count);

            list.RemoveAt(2);
            Console.WriteLine(list.Count);

            Console.WriteLine(list.GetElementAt(0));
            Console.WriteLine(list.GetElementAt(2));
            Console.WriteLine(list.GetElementAt(3));

            list.Insert(4, 2);
            Console.WriteLine();
        }
    }
}
