using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Logger.Contracts;

namespace _01.Logger.Layouts
{
    class XmlLayout : ILayout
    {
        public string FormatMessage(string messageDateTime, string reportLevel, string message)
        {
            StringBuilder msg = new StringBuilder();

            return msg.AppendLine("<log>")
                .AppendLine($"   <date>{messageDateTime}</date>")
                .AppendLine($"   <level>{reportLevel}</level>")
                .AppendLine($"   <message>{message}</message>")
                .Append($"</log>")
                .ToString();
        }
    }
}
