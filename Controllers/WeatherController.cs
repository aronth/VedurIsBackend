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
    public async Task<ActionResult<ForecastResponse>> GetWeather(int station)
    {
        var response = new ForecastResponse();
        var weather = await _weatherScraper.GetWeatherFromStationAsync(station);
        if (weather == null)
        {
            response.Errors = new string[] { "Weather not found" };
            return response;
        }
        response.StationId = station;
        response.Lang = weather.Lang;
        response.IsCached = weather.IsCached;
        response.Station = new StationResponse();
        response.Station.Name = weather.StationForecast.Name;
        response.Station.Forecasts = weather.StationForecast.Forecast.Select(weather => new TimedForecastResponse
        {
            Temperature = weather.T,
            WindDirection = weather.D,
            WindSpeed = weather.F,
        });
        return response;
    }
}