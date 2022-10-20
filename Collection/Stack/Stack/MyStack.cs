using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class MyStack<T>
    {
        private List<T> items =new List<T>();
        public MyStack()
        {
        }

        public void Push(T item)
        {
            items.Add(item);
        }
        public T Pop()
        {
            if(items.Count>0)
            {
                T item = items[items.Count-1];
                items.RemoveAt(items.Count - 1);
                return item;
            }
            else
            {
                throw new Exception("stack null");
            }
        }
        public void Clean()
        {
            items.Clear();
        }
        public void Print()
        {
            for(int i=items.Count-1; i>=0; i--)
            {
                Console.WriteLine($"{items[i]} ");
            }
        }
    }
}
