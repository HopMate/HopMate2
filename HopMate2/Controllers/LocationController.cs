using System;
using HopMate2.Data;
using HopMate2.Models.Dto.Location;
using HopMate2.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HopMate2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly HopMateContext hopMateContext;

        public LocationsController(HopMateContext hopMateContext)
        {
            this.hopMateContext = hopMateContext;
        }

        [HttpGet]
        public IActionResult GetAllLocations()
        {
            var locations = hopMateContext.Locations.ToList();
            return Ok(locations);
        }

        [HttpGet("{id}")]
        public IActionResult GetLocation(Guid id)
        {
            var location = hopMateContext.Locations.FirstOrDefault(l => l.IdLocation == id);
            if (location == null)
            {
                return NotFound();
            }
            return Ok(location);
        }

        [HttpPost]
        public IActionResult AddLocation(LocationAddDto locationAddDto)
        {
            var locationEntity = new Location
            {
                IdLocation = Guid.NewGuid(),
                Address = locationAddDto.Address,
                PC1 = locationAddDto.PC1,
                PC2 = locationAddDto.PC2
            };

            hopMateContext.Locations.Add(locationEntity);
            hopMateContext.SaveChanges();

            return Ok(locationEntity);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLocation(Guid id, LocationUpdateDto locationDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var location = hopMateContext.Locations.FirstOrDefault(l => l.IdLocation == id);

            if (location == null)
                return BadRequest();

            location.Address = locationDto.Address;
            location.PC1 = locationDto.PC1;
            location.PC2 = locationDto.PC2;

            hopMateContext.SaveChanges();

            return Ok(location);
        }
    }
}