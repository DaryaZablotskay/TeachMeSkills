using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class MyQueue<T>
    {
        private List<T> items = new List<T>();
        public MyQueue()
        {
        }
        public void Enqueue(T item)
        {
            items.Add(item);
        }
        public T Dequeue()
        {
            if(items.Count>0)
            {
                T item = items[0];
                items.Remove(item);
                return item;
            }
            else
            {
                throw new Exception("queue null");
            }
        }
        public void Print()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
