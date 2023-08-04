using Microsoft.AspNetCore.Mvc;
using AirportWeatherAPI;

namespace AirportWeatherAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AirportWeatherController : ControllerBase
{
    // bringing in our service
    WeatherForecastService service = new WeatherForecastService();

    private readonly ILogger<AirportWeatherController> _logger;

    public AirportWeatherController(ILogger<AirportWeatherController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAirportWeather")]
    public String Get(string airportID)
    {
        String s = service.GetAirportForecast(airportID);
        return s;
    }
}
