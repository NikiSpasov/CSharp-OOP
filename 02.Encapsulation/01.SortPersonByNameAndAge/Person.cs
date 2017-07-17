﻿using System.Runtime.Remoting.Messaging;

public class Person
    {
        private string firstName;
        private string lastName;
        private int age;


        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is a {Age} years old";           
        }
    }

