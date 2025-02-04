using System;
namespace Abstraction
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            salary s = new salary() { empId = 1, empName = "Prachi", baseSalary = 50000, bonus = 5000 };
            s.Display();
            Console.WriteLine($"Total Salary : {s.calculateSalary()}");
        }
    }
}
