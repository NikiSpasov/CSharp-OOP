using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Logger.Contracts;
using _01.Logger.Enums;

namespace _01.Logger.Appenders
{
    public class FileAppender : IAppender
    {


        public FileAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public LogFile File { get; set; }

        public void Append(string timeStamp, string reportLevel, string message)
        {
            string formattedMasg = this.Layout.FormatMessage(timeStamp, reportLevel, message);
            this.File.Write(formattedMasg);
        }
    }
}
