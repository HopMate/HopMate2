using HopMate2.Data;
using HopMate2.Models.Dto.PassengerTrip;
using HopMate2.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HopMate2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerTripsController : ControllerBase
    {
        private readonly HopMateContext hopMateContext;

        public PassengerTripsController(HopMateContext hopMateContext)
        {
            this.hopMateContext = hopMateContext;
        }

        [HttpGet]
        public IActionResult GetAllPassengerTrips()
        {
            var passengerTrips = hopMateContext.PassengerTrips.ToList();
            return Ok(passengerTrips);
        }

        [HttpGet("{id}")]
        public IActionResult GetPassengerTrip(Guid id)
        {
            var passengerTrip = hopMateContext.PassengerTrips.FirstOrDefault(p => p.IdPassengerTrip == id);
            if (passengerTrip == null)
                return NotFound();

            return Ok(passengerTrip);
        }

        [HttpPost]
        public IActionResult AddPassengerTrip(PassengerTripAddDto dto)
        {
            var entity = new PassengerTrip
            {
                IdPassengerTrip = Guid.NewGuid(),
                IdPassenger = dto.IdPassenger,
                IdTrip = dto.IdTrip,
                IdLocation = dto.IdLocation,
                IdRequestStatus = dto.IdRequestStatus,
                DateRequest = dto.DateRequest,
                Reason = dto.Reason
            };

            hopMateContext.PassengerTrips.Add(entity);
            hopMateContext.SaveChanges();

            return Ok(entity);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePassengerTrip(Guid id, PassengerTripUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var passengerTrip = hopMateContext.PassengerTrips.FirstOrDefault(p => p.IdPassengerTrip == id);
            if (passengerTrip == null)
                return BadRequest();

            passengerTrip.IdPassenger = dto.IdPassenger;
            passengerTrip.IdTrip = dto.IdTrip;
            passengerTrip.IdLocation = dto.IdLocation;
            passengerTrip.IdRequestStatus = dto.IdRequestStatus;
            passengerTrip.DateRequest = dto.DateRequest;
            passengerTrip.Reason = dto.Reason;

            hopMateContext.SaveChanges();

            return Ok(passengerTrip);
        }
    }
}