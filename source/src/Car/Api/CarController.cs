using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Car.Api
{
    [Route("api/car")]
    [ApiController]
    public class CarController : ControllerBase
    {

        // GET: api/<CarController>
        [HttpGet]
        public IEnumerable<CarResponse> Get()
        {
            return new CarResponse[]
            {
                new CarResponse()
                {
                    Id = Guid.NewGuid(),
                    CarNumber = "XW82",
                    Brand = "Audi",
                    Type = "SUV",
                    CarClass = "Luxury"
                },
            };
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
