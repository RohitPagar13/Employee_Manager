using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        private static int id=0;
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int Salary {  get;}

        public Employee(string empName, int salary=10000) {
            id++;
            EmployeeID=id;
            this.EmployeeName= empName;
            this.Salary = salary;
        }
    }
}
