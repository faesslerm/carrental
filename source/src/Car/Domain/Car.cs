using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public class Car : Entity
    {
        public string CarNumber { get; }

        public CarClass CarClass { get; }

        public Brand Brand { get; }

        public Type Type { get; }

    }
}
