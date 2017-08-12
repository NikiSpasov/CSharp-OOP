using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Logger.Contracts;

namespace _01.Logger
{
    using Contracts;
    public class SimpleLayout : ILayout
    {
        public string FormatMessage(string timeStamp, string reportLevel, string message)
        {
           return $"{timeStamp} - {reportLevel} - {message}";
        }
    }
}
