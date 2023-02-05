using WebApi.Models;

namespace WebApi.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task AddEmployee(EmployeeDTO employeeDto);
        Task<Employee> GetEmployee(Guid id);
        Task<List<Employee>> GetAll();
    }
}