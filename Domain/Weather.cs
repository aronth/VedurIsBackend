using System.Xml.Serialization;

namespace WeatherService.Domain; 

[XmlRoot(ElementName="forecasts")]
public class Weather { 

    [XmlElement(ElementName="station")] 
    public List<Station> Station { get; set; } 
}