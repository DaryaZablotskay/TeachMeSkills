using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MyLinkedListNode<T>
    {
        public T _item;
        internal MyLinkedList<T> list;
        public MyLinkedListNode<T> _next;
        public MyLinkedListNode<T> _previous;
        public T Value { get { return _item; } set { _item = value; } }
        public MyLinkedListNode<T> Next
        {
            get
            {
                if (_next == null)
                    return null;
                else
                    return _next;
            }
            set
            {
                _next = value;
            }
        }
        public MyLinkedListNode<T> Previous
        {
            get
            {
                if (_previous == null)
                    return null;
                else
                    return _previous;
            }
            set
            {
                _previous = value;
            }
        }
        public MyLinkedListNode(T item)
        {
            _item = item;
        }
    }
}
