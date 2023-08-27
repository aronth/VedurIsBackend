public class WeatherCheck
{

    public Guid Id { get; set; } = Guid.NewGuid();

    public int StationId { get; set; }

    public DateTime CheckedAt { get; set; } = DateTime.UtcNow;

}