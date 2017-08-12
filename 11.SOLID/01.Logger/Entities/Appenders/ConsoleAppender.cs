using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Logger.Contracts;
using _01.Logger.Enums;

namespace _01.Logger
{
    class ConsoleAppender : IAppender
    {

        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ReportLevel ReportLevel { get; set; }

        public void Append(string timeStamp, string reportLevel, string message)
        {
            string formattedMsg = this.Layout.FormatMessage(timeStamp, reportLevel, message);
            Console.WriteLine(formattedMsg);
        }

        public ILayout Layout { get; }
    }
}
