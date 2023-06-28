using Microsoft.AspNetCore.Mvc;
using MiniProject.Model;
using MiniProject.Services;

namespace MiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices _service;
        public EmployeeController(IEmployeeServices service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            try
            {
                return new ObjectResult(_service.GetAllEmployees());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            try
            {
                return new ObjectResult(_service.GetEmployeeById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            try
            {
                int res = _service.AddEmployee(employee);
                if (res > 0)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("UpdateEmployee")]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            try
            {
                int res = _service.UpdateEmployee(employee);
                if (res > 0)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                int res = _service.DeleteEmployee(id);
                if (res > 0)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}


