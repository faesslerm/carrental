using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public interface ICarRepository : IRepository<Car>
    {
        Car GetByCarNumber(string carNumber);
    }
}
