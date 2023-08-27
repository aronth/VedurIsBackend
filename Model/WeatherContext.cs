using Microsoft.EntityFrameworkCore;

public class WeatherContext : DbContext
{

    public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
    {
    }

    public DbSet<StationForecast> StationForecasts { get; set; }

    public DbSet<WeatherCheck> WeatherChecks { get; set; }


}