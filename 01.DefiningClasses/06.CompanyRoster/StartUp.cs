using System;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        List<Employee> workers = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ', ',', '\n', '\t', '\r' },
                    StringSplitOptions.RemoveEmptyEntries);


            Employee currentEmployee = new Employee
            {
                name = input[0],
                salary = double.Parse(input[1]),
                position = input[2],
                department = input[3]
            };

            int age;

            if (input.Length == 5)
            {
                if (int.TryParse(input[4], out age))
                {
                    currentEmployee.age = age;
                    workers.Add(currentEmployee);
                    continue;
                }
                currentEmployee.email = input[4];
                workers.Add(currentEmployee);
                continue;
            }
            if (input.Length == 6)
            {
                if (int.TryParse(input[4], out age))
                {
                    currentEmployee.age = age;
                    currentEmployee.email = input[5]; 
                    continue;
                }
                currentEmployee.email = input[4];
                currentEmployee.age = int.Parse(input[5]);
            }

            workers.Add(currentEmployee);
        }
        Employee.Printer(workers);

    }
}

