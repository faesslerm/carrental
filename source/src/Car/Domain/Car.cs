using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public class Car : Entity, IAggregateRoot
    {
        public string CarNumber { get; set; }
        public Guid CarClassId { get; set; }
        public CarClass CarClass { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public Guid TypeId { get; set; }
        public Type Type { get; set; }

    }
}
