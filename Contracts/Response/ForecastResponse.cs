public class ForecastResponse
{
    public int StationId { get; set; }
    public string Lang { get; set; } = "is";
    public string[] Errors { get; set; } = new string[] { };
    public bool IsCached { get; set; } = false;

    public StationResponse Station { get; set; }
}