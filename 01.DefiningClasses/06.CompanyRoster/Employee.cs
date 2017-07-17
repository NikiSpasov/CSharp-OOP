
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

public class Employee
{

    public int age;
    public string email;

    public string name;
    public double salary;
    public string position;
    public string department;

    public Employee(string name, double salary, string position, string departament)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = departament;
    }

    public Employee(string email = "n/a", int age = -1)
    {
        this.email = email;
        this.age = age;
    }

    public static string bestDept( List<Employee> employees)
    {
        Dictionary<string, List<double> > deptSalary = new Dictionary<string, List<double>>();

        foreach (var employee in employees)
        {
            if (!deptSalary.ContainsKey(employee.department))
            {
                List<double> salaryes = new List<double>();
                deptSalary.Add(employee.department, salaryes);
            }
           deptSalary[employee.department].Add(employee.salary);

        }
        return deptSalary
            .OrderByDescending(x => x.Value.Average())
            .Take(1)
            .ToDictionary(x => x.Key, y => y.Value)
            .Keys.First();
   
    }

    public static void Printer(List<Employee> employees)
    {
        string best = bestDept(employees);
        Console.WriteLine($"Highest Average Salary: {best}");

        foreach (var employee in employees.Where(x => x.department == best).OrderByDescending(x => x.salary))
        {
            Console.WriteLine($"{employee.name} {employee.salary:f2} " +
                              $"{employee.email} {employee.age}");
        }
    }


}



