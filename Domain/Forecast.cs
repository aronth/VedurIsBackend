using System.Xml.Serialization;

namespace WeatherService.Domain; 

[XmlRoot(ElementName="forecast")]
public class Forecast { 

    [XmlElement(ElementName="ftime")] 
    public string Ftime { get; set; } 

    [XmlElement(ElementName="F")] 
    public int F { get; set; } 
    
    [XmlElement(ElementName="FX")]
    public int FX { get; set; }
    
    [XmlElement(ElementName="FG")]
    public int FG { get; set; }

    [XmlElement(ElementName="D")] 
    public string D { get; set; } 

    [XmlElement(ElementName="T")] 
    public int T { get; set; } 

    [XmlElement(ElementName="W")] 
    public string W { get; set; } 
    
    [XmlElement(ElementName="V")]
    public int V { get; set; }
    
    [XmlElement(ElementName="N")]
    public int N { get; set; }
    
    [XmlElement(ElementName="RH")]
    public int RH { get; set; }
    
    [XmlElement(ElementName="TD")]
    public int TD { get; set; }
}