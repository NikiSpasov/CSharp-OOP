using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Logger.Appenders;
using _01.Logger.Contracts;
using _01.Logger.Enums;

namespace _01.Logger
{
    public class Logger : ILogger
    {
        private IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        private void Log(string timeStamp, string reportLevel, string message)
        {
            foreach (IAppender appender in this.appenders)
            {
                ReportLevel currentReportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevel);
                if (appender.ReportLevel <= currentReportLevel)
                {
                    appender.Append(timeStamp, reportLevel, message);
                }
            }
        }

        public void Error(string timeStamp, string message)
        {
            this.Log(timeStamp, "Error", message );
        }
        public void Info(string timeStamp, string message)
        {
            this.Log(timeStamp, "Info", message);
        }
        public void Fatal(string timeStamp, string message)
        {
            this.Log(timeStamp, "Fatal", message);
        }
        public void Critical(string timeStamp, string message)
        {
            this.Log(timeStamp, "Critical", message);
        }

        public void Warn(string timeStamp, string message)
        {
            this.Log(timeStamp, "Warning", message);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Logger info");
            foreach (IAppender appender in appenders)
            {
                sb.AppendLine(appender.ToString());
            }
            return sb.ToString();
        }
    }
}
