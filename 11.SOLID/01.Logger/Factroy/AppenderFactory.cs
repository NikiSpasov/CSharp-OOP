using _01.Logger.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Factroy
{
    public class AppenderFactory
    {
        public static IAppender GetAppender(string appenderType, ILayout layout)
        {
            Type typeOfAppender = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == appenderType);
            return (IAppender)Activator.CreateInstance(typeOfAppender, layout);
        }
    }
}
