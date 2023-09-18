namespace N38___HT2.Models;

public class WeatherReport
{
    public int ReportId { get; set; }
    public string Location { get; set; }
    public DateTime ReportDate { get; set; }
    public double TemperatureCelsius { get; set; }
}
