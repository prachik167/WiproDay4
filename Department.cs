using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay4
{
    internal class Department : Employee
    {
        public string DeptName { get; set; }
        public decimal Salary { get; set; }

        
        

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Department Name : {DeptName} Salary : {Salary}");
        }
    }
}
