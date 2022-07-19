
using CarRent.Car.Domain;

namespace CarRent.Car.Persistence
{
    public class CarRepository : ICarRepository
    {
        private readonly List<Domain.Car> _context;

        public CarRepository(List<Domain.Car> context)
        {
            _context = context;
        }

        public Domain.Car GetById(Guid id)
        {
            return _context
                .Where(car => car.Id.Equals(id))
                .GetEnumerator()
                .Current;
        }

        public Domain.Car GetByCarNumber(string carNumber)
        {
            return _context
                .Where(car => car.CarNumber.Equals(carNumber))
                .GetEnumerator()
                .Current;
        }

        public void Add(Domain.Car car)
        {
            _context.Add(car);
        }

        public void Update(Domain.Car car)
        {
            var index = _context.IndexOf(car);
            _context.RemoveAt(index);
            _context.Insert(index, car);
        }

        public void Remove(Domain.Car car)
        {
            _context.Remove(car);
        }
    }
}
