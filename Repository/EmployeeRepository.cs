using MiniProject.Data;
using MiniProject.Model;

namespace MiniProject.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            return _context.SaveChanges();
        }

        public int DeleteEmployee(int id)
        {
            int res = 0;
            var employee = _context.Employees.Where(x => x.Deptid == id).FirstOrDefault();
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                res = _context.SaveChanges();
            }
            return res;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _context.Employees.Where(x => x.Deptid == id).FirstOrDefault();
            return employee;
        }

        public int UpdateEmployee(Employee employee)
        {
            int res = 0;
            var emp = _context.Employees.Where(x => x.Eid == employee.Eid).FirstOrDefault();
            if (emp != null)
            {
                emp.Ename = employee.Ename;
                emp.salary = employee.salary;
                emp.Deptid = employee.Deptid;

                res = _context.SaveChanges();
            }
            return res;
        }
    }
}

