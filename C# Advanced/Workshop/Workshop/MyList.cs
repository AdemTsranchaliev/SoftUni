using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop
{
    public class MyList
    {
        private int[] arr;
        private int capacity;
        private int count;

        public MyList() : this(4)
        {
        }

        public MyList(int capacity)
        {
            this.capacity = 4;
            this.arr = new int[4];
        }

        public int Count => this.count;

        public void Add(int element)
        {
            if (this.count == capacity)
            {
                DoubleArray();
            }
            this.arr[this.count] = element;
            this.count++;

        }
        public int RemoveAt(int index)
        {
            CheckIndex(index);
            int removedElement = this.arr[index];
            for (int i = index; i < this.count - 1; i++)
            {
                this.arr[i] = this.arr[i + 1];
            }
            this.count--;
            return removedElement;
        }
        public void InsertAt(int index,int element)
        {
            this.CheckIndex(index);
            if (this.count==capacity)
            {
                DoubleArray();
            }
            for (int i = this.count; i > index; i--)
            {
                this.arr[i] = this.arr[i - 1];
            }
            this.arr[index] = element;
            this.count++;

        }


            
        public bool Contains(int element)
        {
            bool isFound = false;
            for (int i = 0; i < this.count; i++)
            {
                if (this.arr[i] == element)
                {
                    isFound = true;
                    break;
                }
            }
            return isFound;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            CheckIndex(firstIndex);
            CheckIndex(secondIndex);

            int temp = this.arr[firstIndex];
            this.arr[firstIndex] = this.arr[secondIndex];
            this.arr[secondIndex] = temp;
        }
        
        public int this[int index]
        {
            get
            {
                this.CheckIndex(index);

                return this.arr[index];
            }
            set
            {
                this.CheckIndex(index);
                this.arr[index] = value;
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
        private void CheckIndex(int index)
        {
            if (this.Count<=index||index<0)
            {
                throw new IndexOutOfRangeException("Invalid index! Index was out of range!");
            }
        }

    }
}
