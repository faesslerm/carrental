using CarRent.Car.Api;

namespace CarRent.Tests
{
    public class CarControllerTest
    {
        [Fact]
        public void GetTest()
        {
            var controller = new CarController();
            Assert.Equal("value", controller.Get(1));
        }
    }
}
