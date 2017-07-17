using System.Runtime.Remoting.Messaging;

public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;
        

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

        public double Salary
        {
            get { return this.salary; }
            
        }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Person(string firstName, string lastName, int age, double salary)
            : this(firstName, lastName, age)
        {
            this.salary = salary;
        }

        public void IncreaseSalary(double percent)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * percent / 100;      
            }
            else
            {
                this.salary += this.salary * percent / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} get {salary:f2} leva";           
        }
    }

