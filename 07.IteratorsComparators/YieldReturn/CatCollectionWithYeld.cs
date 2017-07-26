using System.Collections;
using System.Collections.Generic;

namespace YieldReturn
{
    class CatCollectionWithYeld : IEnumerable<Cat>
    {
        private List<Cat> cats;

        public CatCollectionWithYeld(List<Cat> cats)
        {
            this.cats = cats;
        }

        public IEnumerator<Cat> GetEnumerator()
        {
            for (int i = 0; i < this.cats.Count; i+=2)
            {
                yield return this.cats[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
