using EmployeeManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _service;

        public DepartmentController(IDepartmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                var departments = _service.GetAll();
                return Ok(departments);
            }
            catch (Exception)
            {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                var department = _service.GetById(id);
                return Ok(department);
            }
            catch (Exception)
            {
                return NoContent();
            }
        }

    }
}
