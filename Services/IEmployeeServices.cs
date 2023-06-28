using MiniProject.Model;

namespace MiniProject.Services
{
    public interface IEmployeeServices
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int id);
    }
}
