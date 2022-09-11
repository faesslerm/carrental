using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public class CarClass : Entity
    {
        public string Name { get; }

        public decimal DailyPrice { get; }
    }
}
