using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IEmployee
    {
        void Display();
        decimal calCulateSalary();
    }
    class Salary : IEmployee {
        public string name { get; set; }
        public int id { get; set; }
        public decimal baseSalary { get; set; }
        public decimal bonus { get; set; }
        public void Display()
        {
            Console.WriteLine($"Employee Name : {name} Employee Id : {id} Base Salary : {baseSalary} bonus : {bonus}");
        }
        public decimal calculateSalary()
        {
            return baseSalary + bonus;
        }
    }
}
