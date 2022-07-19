namespace CarRent.Car.Domain
{
    public interface ICarRepository
    {
        Car GetById(Guid id);

        Car GetByCarNumber(string carNumber);

        // ..

        void Add(Car car);

        void Update(Car car);

        void Remove(Car car);
    }
}
