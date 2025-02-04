using System;
namespace WiproDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Employee employee = new Employee();
            employee.empId = 11;
            employee.empName = "Prachi";
            employee.Show();


            Console.WriteLine("-----------------------------------------");

            Department department = new Department();
            department.DeptName = "ABC";
            department.Salary = 100000;
            department.empId = 12;
            department.empName = "Prachi";
            department.Show();

            Console.WriteLine("-------------------------------------------------");
            Manager mg = new Manager();
            mg.managerId = 13;
            mg.managerName = "Anjali";
            mg.empId = 14;
            mg.empName = "Sona";
            mg.DeptName = "XYZ";
            mg.Salary = 500000;
            mg.Show();*/

            Employee e = new Employee();
            Console.WriteLine("Enter Employee id ");
            e.empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            e.empName = Console.ReadLine();
            e.Show();

            Console.WriteLine("*******************************************************");
            Department d = new Department();
            Console.WriteLine("Enter Department name ");
            d.DeptName = Console.ReadLine();
            d.Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee id ");
            d.empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            d.empName = Console.ReadLine();
            d.Show();

            Console.WriteLine("*******************************************************");
            Manager m = new Manager();
            Console.WriteLine("Enter Manager id ");
            m.managerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Manager Name");
            m.managerName = Console.ReadLine();
            Console.WriteLine("Enter Department name ");
            m.DeptName = Console.ReadLine();
            m.Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee id ");
            m.empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            m.empName = Console.ReadLine();
            m.Show();

            


        }
    }
}