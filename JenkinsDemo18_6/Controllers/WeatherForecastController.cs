using Microsoft.AspNetCore.Mvc;

namespace JenkinsDemo18_6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("getstring")]
        public string Getstring()
        {
            return "abc";
        }

        [HttpGet("getstring2")]
        public string Getstring2()
        {
            return "xyz";
        }  
        
        [HttpGet("getstring6")]
        public string Getstring6()
        {
            return "xyz";
        }     
        
        [HttpGet("getstring7")]
        public string Getstring7()
        {
            return "xyz";
        }  
        
        [HttpGet("getstring8")]
        public string Getstring8()
        {
            return "xyz";
        } 
        
        [HttpGet("getstring9")]
        public string Getstring9()
        {
            return "xyz";
        }     
        
        [HttpGet("getstring10")]
        public string Getstring10()
        {
            return "xyz";
        }        
    }
}
