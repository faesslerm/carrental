using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public class Type : Entity
    {
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
