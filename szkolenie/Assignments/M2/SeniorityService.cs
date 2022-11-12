using System.Security.Cryptography.X509Certificates;

namespace course_alx.Assignments.M2
{
    public class SeniorityService
    {
        public List<Employee> SeniorEmployees;
        public List<Employee> MidEmployees;
        public List<Employee> JuniorEmployees;

        public SeniorityService()
        {
            JuniorEmployees = new List<Employee>();
            MidEmployees = new List<Employee>();
            SeniorEmployees = new List<Employee>();
        }
        public void ClassifySeniorityBySalary(Employee employee)
        {
            if (employee.Salary < 10000 && employee.Salary >= 5000)
            {
                MidEmployees.Add(employee);
            }
            else if (employee.Salary >=10000)
            {
                SeniorEmployees.Add(employee);
            }
            else if (employee.Salary < 5000)
            {
                JuniorEmployees.Add(employee);
            }
            
        }
        public void ClassifySeniorityByExperience(Employee employee)
        {
            if (employee.Experience > 5)
            {
                SeniorEmployees.Add(employee);
            }
            else if (employee.Experience <= 5 && employee.Experience > 2)
            {
                MidEmployees.Add(employee);
            }
            else if (employee.Experience < 2)
            {
                JuniorEmployees.Add(employee);
            }
        }
        public void ClearLists()
        {
            JuniorEmployees.Clear();
            MidEmployees.Clear();
            SeniorEmployees.Clear();
        }
    }
}
