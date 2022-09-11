using CarRent.Car.Api;

namespace CarRent.Tests
{
    public class CarControllerTest
    {
        [Fact]
        public void GetTest()
        {
            var cars = new CarDto[]
            {
                new() {
                Id = Guid.Empty,
                CarNumber = "XW82",
                Brand = "Audi",
                Type = "SUV",
                CarClass = "Luxury"
                }
            };
            var controller = new CarController(null);

            Assert.NotEqual(cars, controller.Get());
        }
    }
}
