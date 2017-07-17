
using System;

public class Worker : Human
{
    protected decimal weekSalary;
    protected decimal workhoursPerDay;
    public Worker(string firstName, string lastName, decimal weekSalary, decimal workhoursPerDay)
        :base(firstName, lastName)
    {
        WeekSalary = weekSalary;
        WorkHoursPerDay = workhoursPerDay;
    }

    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = decimal.Parse($"{value:f2}");
        } 
    }

    public decimal WorkHoursPerDay
    {
        get { return this.workhoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workhoursPerDay = decimal.Parse($"{value:f2}");
        }
    }

    public decimal GetMoneyByHour()
    {
        decimal money = WeekSalary / 5 / (decimal) WorkHoursPerDay;
        return decimal.Parse($"{money:f2}");
    }
    public override string ToString()
    {
        return $"First Name: {base.FirstName}{Environment.NewLine}Last Name: {base.LastName}{Environment.NewLine}" +
               $"Week Salary: {this.WeekSalary}{Environment.NewLine}Hours per day: {this.WorkHoursPerDay}{Environment.NewLine}" +
               $"Salary per hour: {GetMoneyByHour()}";
    }
}

