namespace WebAPI.Models;



public class WeatherForecastModel
{
    public string Temperature { get; set; }
    public string Wind { get; set; }
    public Forecast[] Forecast { get; set; }
}