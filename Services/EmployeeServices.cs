using MiniProject.Model;
using MiniProject.Repository;

namespace MiniProject.Services
{
    public class EmployeeServices: IEmployeeServices
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeServices(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        public int AddEmployee(Employee employee)
        {
            return _repo.AddEmployee(employee);
        }

        public int DeleteEmployee(int id)
        {
            return (_repo.DeleteEmployee(id));
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return _repo.GetEmployeeById(id);
        }

        public int UpdateEmployee(Employee employee)
        {
            return _repo.UpdateEmployee(employee);
        }
    }
}


