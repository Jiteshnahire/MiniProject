using Microsoft.AspNetCore.Mvc;
using MiniProject.Model;
using MiniProject.Services;

namespace MiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServices _service;
        public DepartmentController(IDepartmentServices service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetAllDepartment")]
        public IActionResult GetAllDepartment()
        {
            try
            {
                return new ObjectResult(_service.GetAllDepartment());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetDepartmentById/{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            try
            {
                return new ObjectResult(_service.GetDepartmentById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddDepartment")]
        public IActionResult AddDepartment([FromBody] Department department)
        {
            try
            {
                int res = _service.AddDepartment(department);
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
        [Route("UpdateDepartment")]
        public IActionResult UpdateDepartment([FromBody] Department department)
        {
            try
            {
                int res = _service.UpdateDepartment(department);
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
        [Route("DeleteDepartment/{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            try
            {
                int res = _service.DeleteDepartment(id);
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
