namespace PRN_OOP_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Customer("ALice", "VN",1000));
            list.Add(new Customer("KiKi", "VN", 1300));
            list.Add(new Customer("Xixi", "VN", 1500));

            list.Add(new Employee("Kaka", "VN", 1200));
            list.Add(new Employee("Polo", "VN", 1700));
            list.Add(new Employee("Dentis", "VN", 1900));

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Hight Salary Min Balance");
                Console.WriteLine("3. Find Person By Name");
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
                        AddEmployee(list);
                        break;
                    case 2:
                        HightSalaryMinBalance(list);
                        break;
                    case 3:
                        FindEmployeeByName(list);
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




            Console.ReadLine(); 

        }

        public static void HightSalaryMinBalance(List<Person> list)
        {
            var maxSalary = list.OfType<Customer>().OrderByDescending(c => c.Balance).FirstOrDefault();
            var minBalance = list.OfType<Employee>().OrderBy(c => c.Salary).FirstOrDefault();
            maxSalary.Display();
            minBalance.Display();

        }

        public static void FindEmployeeByName(List<Person> employees)
        {
            Console.Write("Enter Employee Name: ");
            var name = Console.ReadLine();

            foreach (var employee in employees)
            {
                if (employee.Name.ToLower() == name.ToLower())
                {
                    employee.Display();
                }
            }
        }

        public static void AddEmployee(List<Person> employees)
        {
            string type;
            Console.Write("Enter employee type (emp/cus): ");
            type = Console.ReadLine();

            while (type != "emp" && type != "cus")
            {
                Console.Write("Enter employee type (emp/cus): ");
                type = Console.ReadLine();
            }

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            int salary = 0;
            int balance = 0;
            string address;

            try
            {
                Console.Write("Address: ");
                address = Console.ReadLine();

                if (type == "emp")
                {
                    Console.Write("Salary: ");
                    salary = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Balance ");
                    balance = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input, please try again.");
                return;
            }

            if (type.Equals("cus", StringComparison.OrdinalIgnoreCase))
            {
                employees.Add(new Customer(name,address,balance));
            }
            else if (type.Equals("emp", StringComparison.OrdinalIgnoreCase))
            {
                employees.Add(new Employee(name, address, salary));
            }
            else
            {
                Console.WriteLine("Invalid employee type.");
            }
            Console.WriteLine("ssf");
        }


    }
}
