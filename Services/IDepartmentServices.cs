using MiniProject.Model;

namespace MiniProject.Services
{
    public interface IDepartmentServices
    {
        IEnumerable<Department> GetAllDepartment();
        Department GetDepartmentById(int id);
        int AddDepartment(Department department);
        int UpdateDepartment(Department department);
        int DeleteDepartment(int departmentId);
    }
}
