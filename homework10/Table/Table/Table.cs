using System;
using System.Collections.Generic;
using System.Text;

namespace Table
{
    public class Table<T, U, Z>
    {
        public List<T> First = new List<T>();
        public List<U> Second = new List<U>();
        public List<Z> Third = new List<Z>();
        public int Count { get; set; }

        public void AddRow(T first, U second, Z third)
        {
            First.Add(first);
            Second.Add(second);
            Third.Add(third);
            Count++;
        }
        public void DeleteRow(int index)
        {
            First.Remove(First[index]);
            Second.Remove(Second[index]);
            Third.Remove(Third[index]);
            Count--;
        }
        public void Print()
        {
           for(int i=0;i<Count;i++)
            {
                Console.WriteLine("{0,-20} | \t {1,-8} | \t {2, -8}", First[i], Second[i], Third[i]);
            }
        }
    }
}
