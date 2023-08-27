using System.ComponentModel.DataAnnotations;

public class StationForecast
{

    public Guid ForecastId { get; set; } = Guid.NewGuid();

    public int StationId { get; set; }

    public DateTime ObservationTime { get; set; }

    [Key]
    public DateTime ForecastTime { get; set; }

    public string ForecastText { get; set; } = string.Empty;

    public double Temperature { get; set; }

    public double WindSpeed { get; set; }

    public string WindDirection { get; set; }

    public double WindGust { get; set; }

    public double Pressure { get; set; }

    public double Humidity { get; set; }

    public double Visibility { get; set; }

    public double CloudCover { get; set; }

    public double Precipitation { get; set; }

    public double AirQualityIndex { get; set; }

    public double UVIndex { get; set; }

    public double DewPoint { get; set; }

    public double WindChill { get; set; }

    public double HeatIndex { get; set; }

    public double FeelsLike { get; set; }

    public double ChanceOfRain { get; set; }

    public double ChanceOfSnow { get; set; }



}