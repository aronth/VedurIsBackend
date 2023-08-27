using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WeatherService.Domain;

public class WeatherScraper : IWeatherScraper
{

    readonly string WeahtherBaseUrl = "https://xmlweather.vedur.is/";
    readonly WeatherContext _context;

    public WeatherScraper(WeatherContext context)
    {
        _context = context;
    }

    public bool GetWeatherFromDatabase(int stationId)
    {
        var lastCheck = _context.WeatherChecks.OrderByDescending(x => x.CheckedAt).FirstOrDefault(x => x.StationId == stationId);
        if (lastCheck == null)
            return false;
        return lastCheck.CheckedAt.AddMinutes(60) > DateTime.UtcNow;
    }

    public async Task<ForecastResult> GetWeatherFromStationAsync(WeatherStations station)
    {
        return await GetWeatherFromStationAsync((int)station);
    }

    public async Task<ForecastResult> GetWeatherFromStationAsync(int stationId)
    {
        //var IsChached = GetWeatherFromDatabase(stationId);
        var url = GetUrl(stationId);
        using HttpClient client = new HttpClient();
        var xml = await client.GetStringAsync(url);
        XmlSerializer serializer = new XmlSerializer(typeof(Weather));
        using StringReader reader = new StringReader(xml);
        Weather weather;
        try
        {
            weather = (Weather)serializer.Deserialize(reader);
            if (weather == null)
                weather = new Weather();
        }
        catch
        {
            weather = new Weather();
        }

        //if (!IsChached)
        //await SaveToDatabase(stationId, weather);

        return new ForecastResult
        {
            StationId = stationId,
            StationForecast = weather.Station.Where(x => x.Id == stationId).FirstOrDefault(),
            //IsCached = IsChached
        };

    }

    async Task SaveToDatabase(int stationId, Weather weather)
    {
        var check = new WeatherCheck
        {
            StationId = stationId
        };
        //_context.WeatherChecks.Add(check);
        //_context.SaveChanges();
        var forecasts = new List<StationForecast>();
        foreach (var station in weather.Station)
        {
            foreach (var forecast in station.Forecast)
            {
                forecasts.Add(new StationForecast
                {
                    StationId = stationId,
                    ForecastTime = DateTime.Parse(forecast.Ftime),
                    ObservationTime = DateTime.Parse(station.Atime),
                    ForecastText = forecast.W,
                    Temperature = forecast.T,
                    WindSpeed = forecast.F,
                    WindDirection = forecast.D,
                    WindGust = forecast.FG,
                    Visibility = forecast.V,
                    DewPoint = forecast.TD,
                    Humidity = forecast.RH,
                });
            }
        }
        //_context.StationForecasts.AddRange(forecasts);
        //await _context.SaveChangesAsync();
    }

    string GetUrl(int stationId, string lang = "is")
    {
        return $"{WeahtherBaseUrl}/?op_w=xml&type=forec&lang={lang}&view=xml&params=F;FX;FG;D;T;W;V;N;RH;TD&ids={stationId}";
    }
}