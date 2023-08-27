using WeatherService.Domain;

public class ForecastResult
{
    public int StationId { get; set; }
    public string Lang { get; set; } = "is";
    public string[]? Errors { get; set; }
    public bool IsCached { get; set; } = false;
    public bool HasErrors => Errors != null && Errors.Length > 0;

    public Station? StationForecast { get; set; }
}