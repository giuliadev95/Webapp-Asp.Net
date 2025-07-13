using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebappAPI.Controllers
{
    // https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GettAllStudents()
        {
            string[] studentsNames = new string[] { "John", "Maria", "Pitt", "Maika", "Dina" };
            return Ok(studentsNames);
        }
    }
}
