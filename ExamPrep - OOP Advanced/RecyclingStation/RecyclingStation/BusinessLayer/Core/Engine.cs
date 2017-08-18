namespace RecyclingStation.BusinessLayer.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using global::RecyclingStation.BusinessLayer.Contracts;
    using global::RecyclingStation.BusinessLayer.Contracts.Core;
    using global::RecyclingStation.BusinessLayer.Contracts.IO;

    public class Engine : IEngine
    {
        private const string TerminatingCommand = "TimeToRecycle";

        private readonly MethodInfo[] RecyclingStationMethods; 

        private IReader reader;
        private IWriter writer;

        private IRecyclingStation recyclingStation;

        public Engine(IReader reader, IWriter writer, IRecyclingStation recyclingStation)
        {
            this.Reader = reader;
            this.Writer = writer;
            this.RecyclingStation = recyclingStation;

            this.RecyclingStationMethods = this.RecyclingStation.GetType().GetMethods();
        }

        public IRecyclingStation RecyclingStation
        {
            get => recyclingStation;
            private set => recyclingStation = value;
        }

        private IReader Reader
        {
            get => this.reader;
            set => this.reader = value;
        }

        private IWriter Writer
        {
            get => this.writer;
            set => this.writer = value;
        }

        private string[] SplitStringByChar(string toSplit, params char[] toSplitBy)
        {
            return toSplit.Split(toSplitBy, StringSplitOptions.RemoveEmptyEntries);
        }

        public void Run()
        {
            string inputLine;
            while ((inputLine = this.Reader.ReadLine()) != TerminatingCommand)
            {
                string[] commandArgs = this.SplitStringByChar(inputLine, ' ');

                string methodName = commandArgs[0];
                string[] methodNonParsedParams = null;
                if (commandArgs.Length == 2)
                {
                    methodNonParsedParams = this.SplitStringByChar(commandArgs[1], '|');
                }

                MethodInfo methodToIvoke = this.RecyclingStationMethods.FirstOrDefault(m =>
                m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase));

                ParameterInfo[] methodParams = methodToIvoke.GetParameters();

                object[] parsedParams = new object[methodParams.Length];
                for (int currentCoversion = 0; currentCoversion < methodParams.Length;
                    currentCoversion++)
                {
                    Type currentParamType = methodParams[currentCoversion].ParameterType;

                    string toConvert = methodNonParsedParams[currentCoversion];

                    parsedParams[currentCoversion] = Convert.ChangeType(toConvert, currentParamType);
                }

                object result = methodToIvoke.Invoke(this.RecyclingStation, parsedParams);

                this.Writer.GatherOutput(result.ToString());
            }

            this.Writer.WriteGatheredOut();
            
        }
    }
}
