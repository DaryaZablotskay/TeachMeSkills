using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MyLinkedList<T>
    {
        internal MyLinkedListNode<T> head;
        internal MyLinkedListNode<T> last;
        public int Count { get; set; }
        public MyLinkedListNode<T> First { get => head; }
        public MyLinkedListNode<T> Last { get => last; }
        public void Add(T item)
        {
            MyLinkedListNode<T> node = new MyLinkedListNode<T>(item);
            if (head==null)
            {
                node.Next = null;
                node.Value = item;
                head = node;
                last = node;
                Count++;
            }
            else
            {
                head.Next = node;
                node.Value = item;
                last = node;
                node.Next = null;
                Count++;
            }
        }
        public void RemoveAt(int index)
        {

        }

  
    }
}
