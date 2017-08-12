using System.Collections.Generic;

namespace _03.Detail_Printer
{
    public class Program
    {
        public static void Main()
        {
            IEmployee manager = new Manager("Gosho", new List<string>(){"Doc1", "Doc2"});
            IEmployee employee = new Employee("Pesho rabotniko");
            IList<IEmployee> employeesList = new List<IEmployee>(){manager, employee};
            DetailsPrinter printer = new DetailsPrinter(employeesList);
            printer.printDetails();
            
        }
    }
}
