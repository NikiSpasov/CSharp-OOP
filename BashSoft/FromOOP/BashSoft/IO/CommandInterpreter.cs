namespace BashSoft
{
    using System;
    using System.Linq;
    using System.Reflection;
    using BashSoft.Attributes;
    using IO.Commands;
    using Contracts;

    public class CommandInterpreter : IInterpreter
    {
        private IContentComparer judge;
        private IDatabase repository;
        private IDirectoryManager inputOutputManager;

        public CommandInterpreter(IContentComparer judge, IDatabase repository, IDirectoryManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }

        public void InterpretCommand(string input)
        {
            string[] data = input.Split();
            string commandName = data[0];

            try
            {
                IExecutable command = this.ParseCommand(input, commandName, data);
                command.Execute();
            }
            catch (Exception e)
            {
                OutputWriter.DisplayException(e.Message);
            }
        }

        private IExecutable ParseCommand(string input, string command, string[] data)
        {
            object[] parametersForConstructor = new object[]
            {
                input, data
            };
            Type typeOfCommand =
                Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .First(type => type.GetCustomAttributes(typeof(AliasAttribute))
                                       .Where(atr => atr.Equals(command))
                                       .ToArray().Length > 0);
            Type typeOfInterpreter = typeof(CommandInterpreter);

            Command exe = (Command) Activator.CreateInstance(typeOfCommand, parametersForConstructor);

            FieldInfo[] fieldsOfCommand = typeOfCommand
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo[] fieldsOfInterpreter = typeOfInterpreter
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var fieldOfCommand in fieldsOfCommand)
            {
                Attribute atrAttribute = fieldOfCommand.GetCustomAttribute(typeof(InjectAttribute));
                if (atrAttribute != null)
                {
                    if (fieldsOfInterpreter.Any(x => x.FieldType == fieldOfCommand.FieldType))
                    {
                        fieldOfCommand.SetValue(exe, 
                            fieldsOfInterpreter.First(x => x.FieldType == fieldOfCommand.FieldType)
                            .GetValue(this));
                    }
                }
            }
            return exe;
        }        
    }
}