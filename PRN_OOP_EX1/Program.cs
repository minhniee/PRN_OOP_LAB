using System;

namespace PRN_OOP_EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PartTimeEmplyee(25, "John",10));
            employees.Add(new PartTimeEmplyee(18, "Kim",4));
            employees.Add(new PartTimeEmplyee(10, "Lean",6));
            //employees.Add(new PartTimeEmplyee(30, "Kiki", 1));


            employees.Add(new FullTimeEmployee(20, "Hihi"));
            employees.Add(new FullTimeEmployee(30, "Kiki"));
            employees.Add(new FullTimeEmployee(15, "Alice"));



            //FindEmployeeByName(employees);
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Find Employee with Highest Salary");
                Console.WriteLine("3. Find Employee by Name");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid option, please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddEmployee(employees);
                        break;
                    case 2:
                        HighestTimeWorking(employees);
                        break;
                    case 3:
                        FindEmployeeByName(employees);
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
            Console.ReadLine();

        }



        

        public static void HighestTimeWorking(List<Employee> employees)
        {
            var highestFullTime = employees.OfType<FullTimeEmployee>().OrderByDescending(e => e.PaymentPerHour).FirstOrDefault();
            var highestPartTime = employees.OfType<PartTimeEmplyee>().OrderByDescending(e => e.PaymentPerHour).FirstOrDefault();
            Console.WriteLine(highestFullTime);
            Console.WriteLine(highestPartTime);
        }
        public static void FindEmployeeByName(List<Employee> employees)
        {
            Console.Write("Enter Employee Name: ");
            var name = Console.ReadLine();

            foreach (var employee in employees)
            {
                if (employee.Name.ToLower() == name.ToLower())
                {
                    Console.WriteLine(employee.ToString());
                }
            }
        }

        public static void AddEmployee(List<Employee> employees)
        {
            string type;
            Console.Write("Enter employee type (full/part): ");
            type = Console.ReadLine();

            while (type != "full" && type != "part")
            {
                Console.Write("Enter employee type (full/part): ");
                type = Console.ReadLine();
            }

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            int workingHours = 0;
            int paymentPerHour = 0;

            try
            {
                    Console.Write("Enter working hours: ");
                workingHours = int.Parse(Console.ReadLine());
                Console.Write("Enter payment per hour: ");
                paymentPerHour = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input, please try again.");
                return;
            }

            if (type.Equals("full", StringComparison.OrdinalIgnoreCase))
            {
                employees.Add(new FullTimeEmployee( paymentPerHour, name));
            }
            else if (type.Equals("part", StringComparison.OrdinalIgnoreCase))
            {
                employees.Add(new PartTimeEmplyee(paymentPerHour, name, workingHours));
            }
            else
            {
                Console.WriteLine("Invalid employee type.");
            }
            Console.WriteLine("ssf");
        }


    }
}
