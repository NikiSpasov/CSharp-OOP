
using System.Collections;
using System.Collections.Generic;

namespace YieldReturn
{
    public class CatCollection : IEnumerable<Cat>
    {
        private List<Cat> cats;

        public CatCollection(List<Cat> cats)
        {
            this.cats = cats;
        }

        public IEnumerator<Cat> GetEnumerator()
        {
            return new CatEnumerator(this.cats);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.cats.GetEnumerator();
        }
    }

    public class CatEnumerator : IEnumerator<Cat>
    {
        private List<Cat> cats;
        private int currentIndex = -2;

        public CatEnumerator(List<Cat> cats)
        {
            this.cats = cats;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            currentIndex += 2;
            if (currentIndex >= this.cats.Count)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -2;
        }

        public Cat Current => this.cats[currentIndex];

        object IEnumerator.Current => this.Current;
    }
}
