using System.Net.Http;

namespace WeatherWPF;

public class APIHelper
{
    //private static HttpClient client = new();
    public static HttpClient ProvideClient()
    {
        //Grim kode, men det skal lige virke.
        HttpClient client = new();
        return client;
    }
}