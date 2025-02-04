using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay4
{
    internal class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }

        
        public virtual void Show()
        {
            Console.WriteLine($"Employee id is : {empId} Employee name is : {empName}");
        }
    }
}
