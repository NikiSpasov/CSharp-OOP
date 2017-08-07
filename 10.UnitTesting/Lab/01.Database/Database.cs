using System.Collections.Generic;
using System.Linq;

namespace _01.Database
{
    public class Database
    {
        private IEnumerable<int> numbers;

        public Database()
        {
            this.numbers = new List<int>(16);
        }

        public void Add(int number)
        {
            
        }
        public void Remove()
        {

        }
        public List<int> Fetch ()
        {
            return null;
        }
    }
}
