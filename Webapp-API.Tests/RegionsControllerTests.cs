/*
using Xunit;
using WebappAPI.Controllers;
using WebappAPI.Data;
using WebappAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebappAPI.Tests
{
    public class RegionsControllerTests
    {
        private DBContext GetDbContextWithData()
        {
            var options = new DbContextOptionsBuilder<DBContext>()
                .UseInMemoryDatabase(databaseName: "RegionsTestDb")
                .Options;

            var context = new DBContext(options);

            // Add fake data if database is empty
            if (!context.Regions.Any())
            {
                context.Regions.AddRange(new List<Region>
                {
                    new Region { Id = Guid.NewGuid(), Name = "North" },
                    new Region { Id = Guid.NewGuid(), Name = "South" }
                });

                context.SaveChanges();
            }

            return context;
        }

        [Fact]
        public void GetAll_ReturnsOkWithRegions()
        {
            // Arrange
            var context = GetDbContextWithData();
            var controller = new RegionsController(context);

            // Act
            var result = controller.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var regions = Assert.IsAssignableFrom<IEnumerable<Region>>(okResult.Value);

            // Output for debugging
            foreach (var region in regions)
            {
                Console.WriteLine($"Region: {region.Name}");
            }

            Assert.Equal(2, regions.Count());
        }
    }
}
*/

//UNIT TEST

 // Import frameworks for testing
using Xunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// Import controllers, models'tables and Data from the Webapp project
using WebappAPI.Controllers;
using WebappAPI.Models.Domain;
using WebappAPI.Data;
using System.Runtime.CompilerServices;

namespace WebappAPI.Tests
{
    public class RegionsControllerTests
    {
        private DBContext GetDBContextWithData()
        {
            var options = new DbContextOptionsBuilder<DBContext>()
                .UseInMemoryDatabase(databaseName: "RegionsTestDb")
                .Options;


        }
    }
}
