
using CarRent.Car.Domain;
using CarRent.Car.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Car.Persistence
{
    public class CarRepository : ICarRepository
    {
        private readonly CarContext _context;

        public CarRepository(CarContext context)
        {
            _context = context;
        }

        public Domain.Car GetById(Guid id)
        {
            return _context.Cars
                .Where(car => id.Equals(car.Id))
                .Include(car => car.Brand)
                .Include(car => car.CarClass)
                .Include(car => car.Type)
                .First();
        }

        public Domain.Car GetByCarNumber(string carNumber)
        {
            return _context.Cars
                .Where(car => carNumber.Equals(car.CarNumber))
                .Include(car => car.Brand)
                .Include(car => car.CarClass)
                .Include(car => car.Type)
                .First();
        }

        public void Add(Domain.Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public void Update(Domain.Car car)
        {
            _context.Cars.Update(car);
            _context.SaveChanges();
        }

        public void Remove(Domain.Car car)
        {
            _context.Cars.Remove(car);
            _context.SaveChanges();
        }
    }
}
