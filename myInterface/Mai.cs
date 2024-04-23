using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myInterface
{
    internal class Mai
    {
        static void Main(string[] args)
        {
            Employees emp = new Employees("Joy Ndimande", 145236534, 10000.95, "Educator", "Llyod Jane");
            Console.WriteLine("Employee Name: " + emp.GetEmployeeName());
            Console.WriteLine("Employee ID: " + emp.GetEmployeeID());
            Console.WriteLine("Salary: " + emp.GetSalary());
            Console.WriteLine("Department: " + emp.GetDepartmentName());
            Console.WriteLine("HOP: " + emp.GetHOP());
            Console.WriteLine();


            _ = new Employees("David Smith", 202033, 50000.95, "IT", "Lusukama Smith");
            Console.WriteLine("Employee Name: " + emp.GetEmployeeName());
            Console.WriteLine("Employee ID: " + emp.GetEmployeeID());
            Console.WriteLine("Salary: " + emp.GetSalary());
            Console.WriteLine("Department: " + emp.GetDepartmentName());
            Console.WriteLine("HOP: " + emp.GetHOP());
        }
    }
}

