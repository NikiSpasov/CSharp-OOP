using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Logger.Enums;

namespace _01.Logger.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }
        void Append(string timeStamp, string reportLevel, string message);

       
    }
}
