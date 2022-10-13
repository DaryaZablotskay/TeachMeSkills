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
            Console.WriteLine();
        }
    }
}
