using Microsoft.AspNetCore.Mvc;

public class WeatherController : ControllerBase
{

    private readonly IWeatherScraper _weatherScraper;

    public WeatherController(IWeatherScraper weatherScraper)
    {
        _weatherScraper = weatherScraper;
    }

    [HttpGet]
    [Route("/weather")]
    public async Task<ActionResult> GetWeather()
    {
        return Ok(await _weatherScraper.GetWeatherFromStation(422));
    }
}