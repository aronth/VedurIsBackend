using System.Xml.Serialization;

namespace WeatherService.Domain;

[XmlRoot(ElementName = "forecast")]
public class Forecast
{

    [XmlElement(ElementName = "ftime")]
    public string? Ftime { get; set; }

    [XmlElement(ElementName = "F")]
    public double F { get; set; }

    [XmlElement(ElementName = "FX")]
    public double FX { get; set; }

    [XmlElement(ElementName = "FG")]
    public double FG { get; set; }

    [XmlElement(ElementName = "D")]
    public string? D { get; set; }

    [XmlElement(ElementName = "T")]
    public double T { get; set; }

    [XmlElement(ElementName = "W")]
    public string? W { get; set; }

    [XmlElement(ElementName = "V")]
    public double V { get; set; }

    [XmlElement(ElementName = "N")]
    public double N { get; set; }

    [XmlElement(ElementName = "RH")]
    public double RH { get; set; }

    [XmlElement(ElementName = "TD")]
    public double TD { get; set; }
}