using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EmployeeManager
    {
        List<Employee> employees;
        int numEmployees;

        public EmployeeManager()
        {
            employees = new List<Employee>();
            numEmployees = employees.Count;
        }

        public void addEmployee(Employee emp)
        {
            employees.Add(emp);
            Console.WriteLine("Employee Added");
        }

        public void removeEmployee(int id)
        {
            bool flag = true;
            foreach(Employee e in employees)
            {
                if (e.EmployeeID == id)
                {
                    employees.Remove(e);
                    flag = false;
                    Console.WriteLine("Employee Removed");
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Id not found");
            }
        }

        public void search(int id)
        {
            bool flag = true;
            foreach (Employee e in employees)
            {
                if (e.EmployeeID == id)
                {
                    Console.WriteLine("Employee Id: " + e.EmployeeID + " --Employee Name: " + e.EmployeeName + " --Employee Salary: " + e.Salary);
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Id not found");
            }
        }

        public void sortEmployees()
        {
            bool flag;
            for (int i = 0; i < employees.Count-1; i++)
            {
                flag = true;
                for(int j = 0; j < employees.Count-i-1; j++)
                {
                    if (employees[j].Salary > employees[j+1].Salary)
                    {
                        Employee temp = employees[j];
                        employees[j] = employees[j+1];
                        employees[j+1] = temp;
                        flag = false;
                    }
                }
                if(flag)
                {
                    break;
                }
            }
            Console.WriteLine("\nSorted Employees: ");
            foreach (Employee e in employees)
            {
                Console.WriteLine("\nEmployee Id: "+e.EmployeeID+" -- Employee Name: "+e.EmployeeName+ " -- Employee Salary: " + e.Salary);
            }
        }

        public int avgSalary()
        {
            int total = 0;
            int i = 0;
            int avg = 0;
            foreach (Employee e in employees)
            {
                i++;
                total += e.Salary;
                avg = total / i;
            }
            return avg;
        }

        public void displayEmployees()
        {
            Console.WriteLine("\nEmployees with details: ");
            foreach (Employee e in employees)
            {
                Console.WriteLine("\nEmployee Id: " + e.EmployeeID + " -- Employee Name: " + e.EmployeeName + " -- Employee Salary: " + e.Salary);
            }
        }
    }
}
