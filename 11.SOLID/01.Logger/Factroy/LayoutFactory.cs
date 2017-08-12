using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _01.Logger.Contracts;

namespace _01.Logger
{
    public class LayoutFactory
    {
        public static ILayout GetInstance(string typeLayout)
        {
            Type layoutType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == typeLayout);
            return (ILayout) Activator.CreateInstance(layoutType);
        }
    }
}
