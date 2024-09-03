using WeatherMvcFront.Models;

namespace WeatherMvcFront.Services;
public class WeatherClient : IWeatherClient
{
    private readonly HttpClient _httpClient;

    public WeatherClient(HttpClient httpClient)
    {
        this._httpClient = httpClient??throw new ArgumentNullException(nameof(httpClient));
    }

    public async  Task<IEnumerable<WeatherForecast>> GetWeather()
    {
        return await _httpClient
                    .GetFromJsonAsync<IEnumerable<WeatherForecast>>("/GetWeatherForecast");
    }
}