namespace CarRent.Car.Domain
{
    public class Car
    {
        public Guid Id { get; }

        public string CarNumber { get; }

        public CarClass CarClass { get; }

        public Brand Brand { get; }

        public Type Type { get; }

    }
}
