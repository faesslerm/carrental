using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public class Brand : Entity
    {
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
