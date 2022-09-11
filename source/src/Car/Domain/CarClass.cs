using CarRent.Common.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Car.Domain
{
    public class CarClass : Entity
    {
        public string Name { get; set; }

        [Precision(4, 2)]
        public decimal DailyPrice { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
