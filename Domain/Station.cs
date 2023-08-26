using System.Xml.Serialization;

namespace WeatherService.Domain; 

[XmlRoot(ElementName="station")]
public class Station { 

    [XmlElement(ElementName="name")] 
    public string Name { get; set; } 

    [XmlElement(ElementName="atime")] 
    public string Atime { get; set; } 

    [XmlElement(ElementName="err")] 
    public List<string> Err { get; set; } 

    [XmlElement(ElementName="link")] 
    public string Link { get; set; } 

    [XmlElement(ElementName="forecast")] 
    public List<Forecast> Forecast { get; set; } 

    [XmlAttribute(AttributeName="id")] 
    public int Id { get; set; } 

    [XmlAttribute(AttributeName="valid")] 
    public int Valid { get; set; } 

    [XmlText] 
    public string Text { get; set; } 
}