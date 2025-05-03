using HopMate2.Models.Dto.Trip;
using HopMate2.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using HopMate2.Services;
using HopMate2.Data;

namespace HopMate2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        private readonly HopMateContext hopMateContext; 

        public TripsController(HopMateContext hopMateContext)
        {
            this.hopMateContext = hopMateContext;
        }

        [HttpGet]
        public IActionResult GetAllTrips()
        {
            var trips = hopMateContext.Trips.ToList();

            return Ok(trips);
        }

        [HttpGet("{id}")]
        public IActionResult GetTrip(Guid id)
        {
            var trip = hopMateContext.Trips.FirstOrDefault(t => t.IdTrip == id);
            if (trip == null)
            {
                return NotFound();
            }
            return Ok(trip);
        }

        [HttpPost]
        public IActionResult AddTrip(TripAddDto tripAddDto)
        {
            var tripEntity = new Trip()
            {
                IdTrip = Guid.NewGuid(),
                DateDeparture = tripAddDto.DateDeparture,
                DateArrival = tripAddDto.DateArrival,
                AvailableSeats = tripAddDto.AvailableSeats,
                IdDriver = tripAddDto.IdDriver,
                IdVehicle = tripAddDto.IdVehicle,
                IdStatusTrip = tripAddDto.IdStatusTrip
            };

            hopMateContext.Trips.Add(tripEntity);
            hopMateContext.SaveChanges();

            return Ok(tripEntity);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTrip(Guid id, TripDto tripDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var trip = hopMateContext.Trips.FirstOrDefault(t => t.IdTrip == id);
            if (trip == null)
                return NotFound();

            trip.DateArrival = tripDto.DateArrival;
            trip.DateDeparture = tripDto.DateDeparture;
            trip.AvailableSeats = tripDto.AvailableSeats;
            trip.IdDriver = tripDto.IdDriver;
            trip.IdVehicle = tripDto.IdVehicle;
            trip.IdStatusTrip = tripDto.IdStatusTrip;

            hopMateContext.SaveChanges();

            return Ok(trip);
        }
    }
}
