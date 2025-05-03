using HopMate2.Data;
using HopMate2.Models.Dto.TripLocation;
using HopMate2.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HopMate2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripLocationsController : ControllerBase
    {
        private readonly HopMateContext hopMateContext;

        public TripLocationsController(HopMateContext hopMateContext)
        {
            this.hopMateContext = hopMateContext;
        }

        [HttpGet]
        public IActionResult GetAllTripLocations()
        {
            var tripLocations = hopMateContext.TripLocations.ToList();
            return Ok(tripLocations);
        }

        [HttpGet("{id}")]
        public IActionResult GetTripLocation(Guid id)
        {
            var tripLocation = hopMateContext.TripLocations.FirstOrDefault(t => t.IdTripLocation == id);
            if (tripLocation == null)
                return NotFound();

            return Ok(tripLocation);
        }

        [HttpPost]
        public IActionResult AddTripLocation(TripLocationAddDto tripLocationAddDto)
        {
            var tripLocationEntity = new TripLocation
            {
                IdTripLocation = Guid.NewGuid(),
                IdLocation = tripLocationAddDto.IdLocation,
                IdTrip = tripLocationAddDto.IdTrip,
                IsStart = tripLocationAddDto.IsStar
            };

            hopMateContext.TripLocations.Add(tripLocationEntity);
            hopMateContext.SaveChanges();

            return Ok(tripLocationEntity);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTripLocation(Guid id, TripLocationUpdateDto tripLocationUpdateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var tripLocation = hopMateContext.TripLocations.FirstOrDefault(t => t.IdTripLocation == id);

            if (tripLocation == null)
                return BadRequest();

            tripLocation.IdLocation = tripLocationUpdateDto.IdLocation;
            tripLocation.IdTrip = tripLocationUpdateDto.IdTrip;
            tripLocation.IsStart = tripLocationUpdateDto.IsStar;

            hopMateContext.SaveChanges();

            return Ok(tripLocation);
        }
    }
}