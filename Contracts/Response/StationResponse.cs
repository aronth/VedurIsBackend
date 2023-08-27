public class StationResponse
{

    public string Name { get; set; }

    public IEnumerable<TimedForecastResponse> Forecasts { get; set; }

}