using WeatherService.Domain;

public interface IWeatherScraper
{
    Task<Weather> GetWeatherFromStation(int stationId);
}