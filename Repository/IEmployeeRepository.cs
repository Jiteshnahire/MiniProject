using MiniProject.Model;

namespace MiniProject.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int id);

    }
}
