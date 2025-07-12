using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebappAPI.Models.Domain;

namespace WebappAPI.Controllers
{
    // https://localhost:portnumber/api/regions
    [Route("api/controller/regions")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        // GET ALL REGIONS: localhost:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Lombardia",
                    Code = "LM",
                    RegionImageUrl = "https://it.wikipedia.org/wiki/Lombardia#/media/File:Map_of_region_of_Lombardy,_Italy,_with_provinces-it.svg"
                },

                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Piemonte",
                    Code = "PM",
                    RegionImageUrl = "https://it.wikipedia.org/wiki/Lombardia#/media/File:Map_of_region_of_Lombardy,_Italy,_with_provinces-it.svg"
                }
            };
            return Ok(regions);
        }
    }
}
