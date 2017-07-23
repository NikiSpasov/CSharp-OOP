using System.Collections.Generic;
using System.Threading;

namespace Demo
{
    public class MyCustomData<T>
    {
        private List<T> data;

        public MyCustomData()
        {
            this.data = new List<T>();
        }

        public int Count => this.data.Count;

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public void SomeMethod(T first, T second)
        {
            //limited 
            //var result = first + second; - ne raboti, ne znae kakuv tip e;
        }

        public T this[int index] //to add indexator
        {
            get
            {
                return this.data[index];
            }
            //set { this.data[index] = value; } - only if you want to 
            //be read AND write, if it's only with getter - readOnly
        } 
    }
}
