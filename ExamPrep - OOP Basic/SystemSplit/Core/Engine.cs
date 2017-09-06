using System;

public class Engine
    {
        readonly CommandInterpreter interpreter = new CommandInterpreter();
        public void Run()
        {
            string input;

            while ((input = Console.ReadLine()) != "System Split")
            {
                
                string[] args = input.Split('(');
                string command = args[0];
                string[] dataForEntity = args[1].Split(new[] {'(', ')', ' ', ','}, 
                    StringSplitOptions.RemoveEmptyEntries);
                this.interpreter.Interpret(command, dataForEntity);             
            }
            this.interpreter.Interpret("System", new String []{});
        }
    }

