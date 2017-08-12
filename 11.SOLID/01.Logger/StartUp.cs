using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using _01.Logger.Appenders;
using _01.Logger.Contracts;
using _01.Logger.Enums;
using _01.Logger.Factroy;
using _01.Logger.Layouts;

namespace _01.Logger
{
    public class StartUp
    {
        public static void Main()
        {
            int appenderCount = int.Parse(Console.ReadLine());
            IAppender[] appenders = new IAppender[appenderCount];

            for (int i = 0; i < appenderCount; i++)
            {
                string[] appenderInfo = Console.ReadLine().Split();
                ILayout currentLayout = LayoutFactory.GetInstance(appenderInfo[1]);
                IAppender currentAppender = AppenderFactory.GetAppender(appenderInfo[0], currentLayout);
                if (appenderInfo.Length > 2)
                {
                    string enumName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase
                        (appenderInfo[2].ToLower());
                    currentAppender.ReportLevel = (ReportLevel) (Enum.Parse(typeof(ReportLevel), enumName));
                }
                appenders[i] = currentAppender;
            }
            Logger myLogger = new Logger(appenders);

            string inputMsg;
            while ((inputMsg = Console.ReadLine()) != "END")
            {
                var tokens = inputMsg.Split('|');
                string methodName =
                    CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tokens[0].ToLower());
                MethodInfo currentMethod = typeof(Logger).GetMethod(methodName);
                currentMethod.Invoke(myLogger, new object[] {tokens[1], tokens[2]});

            }
            Console.WriteLine(myLogger);

        }
    }
}
