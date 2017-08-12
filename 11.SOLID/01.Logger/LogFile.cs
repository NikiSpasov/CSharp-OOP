using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger
{
    public class LogFile
    {
        private const string DefaultFileName = "log.txt";
        private StringBuilder stringBuilder;

        public LogFile()
        {
            this.stringBuilder = new StringBuilder();
        }

        public int Size { get; private set; }

        private int GetLetterOnlySum(string message)
        {
            return message
                .Where(c => char.IsLetter(c))
                .Sum(c => c);
        }
        public void Write(string message)
        {
            this.stringBuilder.AppendLine(message);
            File.AppendAllText(DefaultFileName, message + Environment.NewLine);
            this.Size = this.GetLetterOnlySum(message);
        }
    }
}
