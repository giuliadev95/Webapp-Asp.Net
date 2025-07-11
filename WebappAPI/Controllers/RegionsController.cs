using Microsoft.AspNetCore.Mvc;

namespace WebappAPI.Controllers
{
        // https://localhost:portnumber/api/Students
        [Route("api/controller")]
        [ApiController]
        public class RegionsController : ControllerBase
        {
            [HttpGet]
            public IActionResult Index()
            {
                string[] regions = new string[] { "String example" };
                return Ok(regions);
            }

        }
}
