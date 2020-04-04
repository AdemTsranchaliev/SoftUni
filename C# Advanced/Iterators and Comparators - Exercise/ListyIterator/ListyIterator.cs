using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>:IEnumerable<T>
    {
        private List<T> store;
        private int index;
        public ListyIterator(List<T> data)
        {
            this.store = new List<T>(data);
            this.index = 0;
        }

        public bool Move()
        {
            if (!HasNext())
            {
                return false;
            }
            this.index++;

            return true;
        }
        public bool HasNext()
        {
            if (this.index+1>=this.store.Count)
            {
                return false;
            }

            return true;
        }
        public void Print()
        {
            if (this.store.Count==0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else if(this.index < this.store.Count)
            {
                Console.WriteLine(this.store[this.index]);

            }
        }



        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.index; i++)
            {
                yield return this.store[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
