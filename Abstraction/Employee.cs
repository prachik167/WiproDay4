using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }

        public void Display()
        {
            Console.WriteLine($"Employee Id : {empId} Employee Name: {empName} ");
        }
        public abstract decimal calculateSalary();
    }

    class salary : Employee
    {
        public decimal baseSalary { get; set; }
        public decimal bonus { get; set; }

        public override decimal calculateSalary()
        {
            return baseSalary + bonus; ;
        }
    }
}
