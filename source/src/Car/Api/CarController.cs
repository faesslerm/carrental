using CarRent.Car.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Car.Api
{
    [Route("api/car")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _repository;
        public CarController(ICarRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<CarController>
        [HttpGet]
        public IEnumerable<CarDto> Get()
        {
            return new CarDto[]
            {
                new CarDto()
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
        public CarDto Get(Guid id)
        {
            var car = _repository.GetById(id);
            return new CarDto()
            {
                Id = car.Id,
                CarNumber = car.CarNumber,
                Brand = car.Brand.Name,
                Type = car.Type.Name,
                CarClass = car.CarClass.Name,
            };
        }

        // POST api/<CarController>
        [HttpPost]
        public Guid Post([FromBody] CarDto dto)
        {
            var car = new Domain.Car()
            {
                CarNumber = dto.CarNumber,
                CarClass = new CarClass()
                {
                    Name = dto.CarClass,
                },
                Brand = new Brand()
                {
                    Name = dto.Brand
                },
                Type = new Domain.Type()
                {
                    Name = dto.Type
                }
            };
            _repository.Add(car);
            return car.Id;
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var car = _repository.GetById(id);
            _repository.Remove(car);
        }
    }
}
