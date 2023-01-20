class MenageEmployee
{
    public static void Run()
    {
        Employee employee = new Employee("John", "Doe");
        Console.WriteLine(employee.ToString());

        while (true)
        {
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change contract");
            Console.WriteLine("3. Create new contract");
            Console.WriteLine("4. Get salary");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter new first name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter new last name:");
                string lastName = Console.ReadLine();

                employee.ChangeName(firstName, lastName);
                Console.WriteLine("Name changed to " + employee.FirstName + " " + employee.LastName);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter contract type (1 for Trainee, 2 for Full-time, 3 for new contract)");
                int contractType = int.Parse(Console.ReadLine());

                if (contractType == 1)
                {
                    employee.ChangeContract(new TraineeContract());
                }
                else if (contractType == 2)
                {
                    Console.WriteLine("Enter number of overtime hours:");
                    int overtimeHours = int.Parse(Console.ReadLine());

                    employee.ChangeContract(new FullTimeContract() { OvertimeHours = overtimeHours });
                }
                else if (contractType == 3)
                {
                    Console.WriteLine("Enter the salary:");
                    double salary = double.Parse(Console.ReadLine());

                    employee.ChangeContract(new CustomContract() { Salary = salary });
                }

                Console.WriteLine("Contract changed.");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter the salary:");
                double salary = double.Parse(Console.ReadLine());
                CustomContract customContract = new CustomContract() { Salary = salary };
                Console.WriteLine("New contract created with salary: " + customContract.Salary);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Salary: " + employee.GetSalary());
            }
            else if (choice == 5)
            {
                break;
            }
        }
    }
}