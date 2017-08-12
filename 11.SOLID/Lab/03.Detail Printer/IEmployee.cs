using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Detail_Printer
{
    public interface IEmployee
    {
        string Name { get; }

        void PrintDetails();
    }
}
