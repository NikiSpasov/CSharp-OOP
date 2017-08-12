﻿using System;

namespace _03.Detail_Printer
{
    public class Employee : IEmployee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
        public void PrintDetails()
        {
            Console.WriteLine(this.Name); ;
        }
    }
}