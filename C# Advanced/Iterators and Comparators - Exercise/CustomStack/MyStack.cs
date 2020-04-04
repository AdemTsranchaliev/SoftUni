using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class MyStack<T>:IEnumerable<T>
    {
        private T[] stack;
        private int capacity;
        private int index;
        public MyStack()
        {
            this.capacity = 2;
            this.stack = new T[this.capacity];
            this.index = 0;
        }

        public void Push(T element)
        {

            if (this.index>=this.capacity)
            {
                DoubleArray();
            }
            this.stack[this.index] = element;
            this.index++;
        }
        public void Pop()
        {
            if (this.index<=0)
            {
                Console.WriteLine("No elements");
            }
            else
            this.index--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.index-1; i >= 0; i--)
            {
                yield return this.stack[i];
            }
        }

        private void DoubleArray()
        {
            this.capacity *= 2;
            var temp = new T[this.capacity];
            for (int i = 0; i < this.stack.Length; i++)
            {
                temp[i] = this.stack[i];
            }
            this.stack = temp;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
