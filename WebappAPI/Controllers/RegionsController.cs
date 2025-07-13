using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebappAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;
using WebappAPI.Data;

namespace WebappAPI.Controllers
{
    // https://localhost:portnumber/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly DBContext dbContext;

        public RegionsController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET ALL REGIONS: localhost:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = dbContext.Regions.ToList();
            return Ok(regions);
        }
    }
}
