using WeatherService.Domain;

public interface IWeatherScraper
{
    Task<ForecastResult> GetWeatherFromStationAsync(WeatherStations station);
    Task<ForecastResult> GetWeatherFromStationAsync(int stationId);
}