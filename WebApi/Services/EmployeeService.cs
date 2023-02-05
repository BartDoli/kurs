using CommonFunctinalities.Services.Interfaces;
using System;
using WebApi.Models;
using WebApi.Services.Interfaces;

namespace WebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private ITaxService _taxService;
        private IEmployeeRepository _employeeRepository;
        private IDepartmentRepository _departmentRepository;
        private IPaycheckRepository _paycheckRepository;

        public EmployeeService(ITaxService taxService,
                               IEmployeeRepository employeeRepository,
                               IDepartmentRepository departmentRepository,
                               IPaycheckRepository paycheckRepository)
        {
            _taxService = taxService;
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
            _paycheckRepository = paycheckRepository;
        }

        public async Task AddEmployee(EmployeeDTO employeeDto)
        {
            var paycheck = GeneratePayCheck(employeeDto.LastName, employeeDto.DepartmentName);
            _paycheckRepository.Create(paycheck);
            var department = await GetDepartment(employeeDto.DepartmentName);
            var employee = CreateEmployee(employeeDto, paycheck.Id, department.Id);
            await _employeeRepository.Create(employee);
         }

        public Task<Employee> GetEmployee(Guid id)
        {
            throw new NotImplementedException();
        }
        public Task<List<Employee>> GetAll()
        {
            throw new NotImplementedException();
        }

        private Paycheck GeneratePayCheck(string lastName, string departmentName)
        {
            var random = new Random();
            var paycheck = new Paycheck
            {
                Id = Guid.NewGuid(),
                PaycheckNumber = $"{lastName}/{departmentName}" + random.Next(1, 100).ToString()
            };
            return paycheck;
        }

        private async Task<Department> GetDepartment(string departmentName)
        {
            var department = await _departmentRepository.GetByName(departmentName);
            return department;
        }

        private Employee CreateEmployee(EmployeeDTO employeeDto, Guid paycheckId, Guid departmentId)
        {
            var employee = new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                Email = employeeDto.Email,
                DepartmentId = departmentId,
                PaycheckId = paycheckId
            };
            return employee;
        }
    }
}