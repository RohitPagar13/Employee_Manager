namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager em = new EmployeeManager();

            while(true)
            {
                Console.WriteLine("\nwhat you want? \n1: Add Employee \n2: Remove Employee \n3: Search Employee \n4: Sort Employees \n5: Average Salary of all Employees \n6: Display all employees \n0: Exit from the System");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("\nExiting from System");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter Name of the Employee");
                        string Name = Console.ReadLine();
                        Console.WriteLine("\nEnter Salary of the Employee");
                        string Salary = Console.ReadLine();
                        if (Name == null)
                        {
                            Console.WriteLine("\nName cannot be null");
                        }
                        else
                        {
                            if(Salary == null || Salary == "")
                            {
                                em.addEmployee(new Employee(Name));
                            }
                            else
                            {
                                try
                                {
                                    em.addEmployee(new Employee(Name, Convert.ToInt32(Salary)));
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Enter valid Salary");
                                }
                                
                            }
                                
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nEnter id of the Employee");
                        int id = Convert.ToInt32(Console.ReadLine());
                        
                        em.removeEmployee(id);
                       
                        break;

                    case 3:
                        Console.WriteLine("\nEnter Id of the Employee");
                        em.search(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 4:
                        em.sortEmployees();
                        break;

                    case 5:
                        Console.WriteLine(em.avgSalary());
                        break;

                    case 6:
                        em.displayEmployees();
                        break;

                    default:
                        Console.WriteLine("\nEnter valid Choice");
                        break;
                }
            
            }

        }
    }
}