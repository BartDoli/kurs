namespace course_alx.Assignments.M2
{
    public class SeniorityServiceTest
    {
        public static void Run()
        {
            var seniorityService = new SeniorityService();
            var employee1 = new Employee("Damian", 5000, 2);
            var employee2 = new Employee("Marta", 4000, 1);
            var employee3 = new Employee("Bartek", 6000, 3);
            var employee4 = new Employee("Ania", 20000, 5);
            var employee5 = new Employee("Mivhał", 10000, 4);
            seniorityService.ClassifySeniorityBySalary(employee1);
            seniorityService.ClassifySeniorityBySalary(employee2);
            seniorityService.ClassifySeniorityBySalary(employee3);
            seniorityService.ClassifySeniorityBySalary(employee4);
            seniorityService.ClassifySeniorityBySalary(employee5);

            Console.WriteLine("Sklasyfikowani po zarobkach: ");
            Console.WriteLine("Juniors: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors: ");
            PresentEmployees(seniorityService.SeniorEmployees);
            seniorityService.ClearLists();

            seniorityService.ClassifySeniorityByExperience(employee1);
            seniorityService.ClassifySeniorityByExperience(employee2);
            seniorityService.ClassifySeniorityByExperience(employee3);
            seniorityService.ClassifySeniorityByExperience(employee4);
            seniorityService.ClassifySeniorityByExperience(employee5);
            Console.WriteLine("\n\nSklasyfikowani po doświadczeniu: ");
            Console.WriteLine("Juniors: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors: ");
            PresentEmployees(seniorityService.SeniorEmployees);
        }

        public static void PresentEmployees(List<Employee> employees)
        {
            foreach(var employee in employees)
            {
                Console.WriteLine($"Emplyee : {employee.Name}");
            }
        }
    }
}
