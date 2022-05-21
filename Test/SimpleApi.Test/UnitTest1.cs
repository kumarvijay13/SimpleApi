using Xunit;
using SimpleApi.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SimpleApi.Test;

public class UnitTest1
{

 


    [Fact]
    public void Test1()
    {
        
      

    }

 [Fact]
   public void GetNameTestCase()
   {
        var serviceProvider = new ServiceCollection()
                            .AddLogging()
                            .BuildServiceProvider();

       var factory = serviceProvider.GetService<ILoggerFactory>();

       var logger = factory.CreateLogger<WeatherForecastController>();
       WeatherForecastController weatherForecast = new WeatherForecastController(logger);

     var Name = weatherForecast.Get(1);
     Assert.Equal("Hello Buddy",Name.Value);
  
   }

}