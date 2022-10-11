using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MyLinkedList<T>
    {
        internal MyLinkedListNode<T> head;
        public int Count { get; set; }
        public MyLinkedListNode<T> First { get => head; }
        public MyLinkedListNode<T> Last { get; set; }
        public void Add(T item)
        {
            MyLinkedListNode<T> node = new MyLinkedListNode<T>(item);
            if (head==null)
            {
                node.Next = node;
                node.Previous = null;
                node.Value = item;
                head = node;
                Count++;
            }
            else
            {
                head.Next = node;
                node.Previous = head;
                node.Value = item;
                Count++;
            }
        }
        public void RemoveAt(int index)
        {

        }

  
    }
}
