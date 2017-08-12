namespace _04.Recharge
{
    using System;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base (id)
        {
        }

        public void Work(int hours)
        {
           
                base.workingHours += hours;     
        }

        public void Sleep()
        {
            
        }
    }
}