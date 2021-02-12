using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeaksSoftware.VehicleTrackingSystem.API.Controllers
{
    [Route("api/vehicles/{vehicleId}/locations")]
    [ApiController]
    public class VehicleLocationsController : ControllerBase
    {
        // GET: api/<VehicleLocationController>
        [HttpGet]
        public IEnumerable<string> Get([FromRoute] string vehicleId)
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VehicleLocationController>/5
        [HttpGet("{id}")]
        public string Get([FromRoute] string vehicleId, int id)
        {
            return "value";
        }

        // POST api/<VehicleLocationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VehicleLocationController>/5
        [HttpPut("{id}")]
        public void Put([FromRoute] string vehicleId, int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicleLocationController>/5
        [HttpDelete("{id}")]
        public void Delete([FromRoute] string vehicleId, int id)
        {
        }
    }
}
