

namespace _03.Detail_Printer
{
    using System;
    using System.Collections.Generic;

    public class Manager : IEmployee
    {
        public Manager(string name, ICollection<string> documents)
        {
            this.Documents = new List<string>(documents);
            this.Name = name;
        }

        public IReadOnlyCollection<string> Documents { get; set; }
        public string Name { get; private set; }

        public void PrintDetails()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(string.Join(Environment.NewLine, this.Documents)); ;
        }
    }
}
