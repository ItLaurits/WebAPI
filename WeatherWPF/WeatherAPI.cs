using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WeatherWPF;

public class WeatherAPI
{



    public static async Task<WeatherForecastModel> getWeather(HttpClient client, string city)
    {
        var forecast =
                await client.GetFromJsonAsync<WeatherForecastModel>("https://goweather.herokuapp.com/weather/" + city);
            return forecast;
    }

}