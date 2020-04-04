using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class FrogJump : IEnumerable<int>
    {
        private List<int> stoneNumbers;

        public FrogJump(List<int> stones)
        {
            this.stoneNumbers = new List<int>(stones);
        }

        public IEnumerator<int> GetEnumerator()
        {

            for (int i = 0; i < this.stoneNumbers.Count; i++)
            {
                if (i%2==0)
                {
                    yield return this.stoneNumbers[i];
                }
            }
            for (int i = this.stoneNumbers.Count-1; i >=0 ; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.stoneNumbers[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
