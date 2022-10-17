using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MyLinkedList<T>
    {
        internal MyLinkedListNode<T> head;
        internal MyLinkedListNode<T> last;
        internal MyLinkedListNode<T> current;
        public int Count { get; set; }
        public MyLinkedListNode<T> First { get => head; }
        public MyLinkedListNode<T> Last { get => last; }
        public MyLinkedList()
        {
        }

        public void Add(T item)
        {
            MyLinkedListNode<T> node = new MyLinkedListNode<T>(item);
            if (head == null)
            {
                node.Next = null;
                node.Value = item;
                head = node;
                last = node;
                Count++;
                current = node;
            }
            else
            {
                current.Next = node;
                node.Value = item;
                last = node;
                node.Next = null;
                Count++;
                current = node;
            }
        }
        public void RemoveAt(int index)
        {
            int countInd = 1;
            var previuos = First;
            var current = First.Next;

            if (index == 0)
            {
                head = head.Next;
                Count--;
                return;
            }
            else
            {
                while (countInd != index)
                {
                    previuos = current;
                    current = current.Next;
                    countInd++;
                }
                if(index != Count)
                {
                    previuos.Next = current.Next;
                    current.Next = null;
                    Count--;
                }
                else
                {
                    previuos.Next = null;
                    Count--;
                }
            }
        }
        public T GetElementAt(int index)
        {
            int countInd = 1;
            var previuos = First;
            var current = First.Next;

            if (index == 0)
            {
                return head.Value;
            }
            else
            {
                while (countInd != index)
                {
                    previuos = current;
                    current = current.Next;
                    countInd++;
                }
                if (index != Count)
                {
                    return current.Value;
                }
                else
                {
                    return last.Value;
                }
            }
        }
        public void Insert(T item, int index)
        {
            int countInd = 1;
            var previuos = First;
            var current = First.Next;
            MyLinkedListNode<T> node = new MyLinkedListNode<T>(item);

            if (index == 0)
            {
                node.Value = item;
                node.Next = head;
                Count++;
                return;
            }
            else
            {
                while (countInd != index)
                {
                    previuos = current;
                    current = current.Next;
                    countInd++;
                }
                    previuos.Next = node;
                    node.Next = current;
                    node.Value = item;
                    Count++;
            }
        }
    }
}
