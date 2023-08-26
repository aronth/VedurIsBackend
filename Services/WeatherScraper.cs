using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WeatherService.Domain;

public class WeatherScraper : IWeatherScraper
{

    readonly string WeahtherBaseUrl = "https://xmlweather.vedur.is/";

    public async Task<Weather> GetWeatherFromStation(int stationId)
    {
        var url = GetUrl(stationId);
        using HttpClient client = new HttpClient();
        var xml = await client.GetStringAsync(url);
        XmlSerializer serializer = new XmlSerializer(typeof(Weather));
        using StringReader reader = new StringReader(xml);
        var weather = (Weather)serializer.Deserialize(reader);

        return weather;
    }

    string GetUrl(int stationId, string lang = "is")
    {
        return $"{WeahtherBaseUrl}/?op_w=xml&type=forec&lang={lang}&view=xml&params=F;FX;FG;D;T;W;V;N;RH;TD&ids={stationId}";
    }
}