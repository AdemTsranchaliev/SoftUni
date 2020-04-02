using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop
{
    public class MyStack
    {
        private int[] arr;
        private int capacity;
        private int count;

        public MyStack():this(4)
        {

        }
        public MyStack(int capacity)
        {
            this.capacity = capacity;
            this.arr = new int[capacity];
        }
        public void Push(int element)
        {
            if (this.capacity==this.count)
            {
                this.DoubleArray();
            }
            this.arr[count] = element;
            this.count++;
        }
        public int Pop()
        {
            if (this.count<=0)
            {
                throw new Exception("Empty stack");
            }

            int element = this.arr[this.count-1];
            this.count--;

            return element;
            
       
        }
        public int Peek()
        {
            if (this.count <= 0)
            {
                throw new Exception("Empty stack");
            }

            return this.arr[this.count - 1];
        }
        public void ForEach(Action<int> action)
        {
            foreach (var item in this.arr)
            {
                action(item);
            }
        }
        private void DoubleArray()
        {
            this.capacity *= 2;
            int[] tempArray = new int[capacity];
            for (int i = 0; i < this.count; i++)
            {
                tempArray[i] = this.arr[i];
            }
            this.arr = tempArray;
        }
    }
}
