using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Contracts
{
    public interface ILayout
    {
        string FormatMessage(string timeStamp, string reportLevel, string message);
    }
}
