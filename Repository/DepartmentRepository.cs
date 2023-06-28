using MiniProject.Data;
using MiniProject.Model;

namespace MiniProject.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;
        public DepartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            return _context.SaveChanges();
        }

        public int DeleteDepartment(int id)
        {
            int res = 0;
            var department = _context.Departments.Where(x => x.Deptid == id).FirstOrDefault();
            if (department != null)
            {
                _context.Departments.Remove(department);
                res = _context.SaveChanges();
            }
            return res;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            var department = _context.Departments.Where(x => x.Deptid == id).FirstOrDefault();
            return department;
        }

        public int UpdateDepartment(Department department)
        {
            int res = 0;
            var dep = _context.Departments.Where(x => x.Deptid == department.Deptid).FirstOrDefault();
            if (dep != null)
            {
                dep.Deptname = department.Deptname;

                res = _context.SaveChanges();
            }
            return res;
        }

       
    }
}
