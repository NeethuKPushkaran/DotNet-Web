using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.api.Controllers
{
    //https:localhost: 7274/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //GET: https:localhost: 7274/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "Tara", "Neethu", "John", "David", "Bhaskar" };
            return Ok(studentNames);
        }
    }
}
