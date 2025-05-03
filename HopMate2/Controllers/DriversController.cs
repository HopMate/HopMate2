using HopMate2.Models.Dto.Driver;
using HopMate2.Models.Entities;
using HopMate2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HopMate2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly HopMateContext hopMateContext;

        public DriversController(HopMateContext hopMateContext)
        {
            this.hopMateContext = hopMateContext;
        }

        [HttpGet("{id}")]
        public IActionResult GetDriver(Guid id)
        {
            var driver = hopMateContext.Drivers.FirstOrDefault(d => d.IdDriver == id);

            if (driver == null)
                return NotFound();

            return Ok(driver);
        }

        [HttpGet]
        public IActionResult GetAllDrivers()
        {
            var drivers = hopMateContext.Drivers.ToList();
            return Ok(drivers);
        }

        [HttpPost]
        public IActionResult AddDriver(DriverAddDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var driver = new Driver
            {
                IdDriver = dto.IdDriver,
                DrivingLicense = dto.DrivingLicense
            };

            hopMateContext.Drivers.Add(driver);
            hopMateContext.SaveChanges();

            return Ok(driver);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDriver(Guid id, DriverUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var driver = hopMateContext.Drivers.FirstOrDefault(d => d.IdDriver == id);

            if (driver == null)
                return NotFound();

            driver.DrivingLicense = dto.DrivingLicense;
            hopMateContext.SaveChanges();

            return Ok(driver);
        }
    }
}
