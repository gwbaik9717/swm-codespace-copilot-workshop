// add a namespace for WeatherForecastController
using WebApi.Controllers;

namespace WebApiTests;

[TestClass]
public class WeatherForecastControllerTests
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    // add a test method that tests the GetRange method of WeatherForcastController
    [TestMethod]
    public void TestMethod2()
    {
        // arrange
        var controller = new WeatherForecastController(null);

        // act
        var result = controller.GetRange(new DateRange { Length = 5 });

        // assert
        Assert.AreEqual(5, result.Count());
    }
}