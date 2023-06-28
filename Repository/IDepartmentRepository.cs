using MiniProject.Model;

namespace MiniProject.Repository
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        int AddDepartment(Department department);
        int UpdateDepartment(Department department);
        int DeleteDepartment(int id);

    }
}
