using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay4
{
    internal class Manager : Department
    {
        public decimal managerId {  get; set; }
        public string managerName { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Manager Id : {managerId} Manager Name : {managerName}");
        }
    }
}
