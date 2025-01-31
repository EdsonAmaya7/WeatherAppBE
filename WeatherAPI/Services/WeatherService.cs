using System.Collections.Generic;
using WeatherAPI.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WeatherAPI.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private string ApiKey = "Please assign the api key";
        private const string ApiUrl = "https://api.openweathermap.org/data/2.5/forecast";
        private const string apiPlaces = "https://search.reservamos.mx/api/v2/places";

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CityResponse>> GetMostVisitedCities()
        {
            try
            {
                var cities = await _httpClient.GetFromJsonAsync<List<City>>(apiPlaces);
                List<CityResponse> citiesResponse = new();

                if (cities != null && cities.Count > 0)
                {
                    List<TopCities> topCities = cities
                                   .Where(x => x.result_type == "city")
                                   .OrderByDescending(x => Convert.ToDouble(x.popularity)).Take(10)
                                   .Select(x => new TopCities
                                   {
                                       display = x.display,
                                       lat = x.lat,
                                       @long = x.@long
                                   })
                                   .ToList();


                    citiesResponse = await GetTemperature(topCities);
                }

                return citiesResponse ?? new List<CityResponse>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error en la solicitud: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
            return new List<CityResponse>();
        }

        public async Task<List<CityResponse>> GetTemperature(List<TopCities> topCities)
        {
            List<CityResponse> cities = new();
            string query = "";
            foreach (var x in topCities)
            {
                query = $"{ApiUrl}?lat={x.lat}&lon={x.@long}&appid={ApiKey}&lang=sp,es&units=metric&cnt=1";
                var weatherConditions = await _httpClient.GetFromJsonAsync<ForecastResponse>(query);

                if (weatherConditions != null)
                {
                    var temperature = weatherConditions.List[0].Main.Temp;
                    var weatherCondition = weatherConditions.List[0].Weather[0].Main;

                    cities.Add(new CityResponse
                    {
                        display = x.display,
                        lat = x.lat,
                        @long = x.@long,
                        currentTemperature = temperature.ToString(),
                        weatherCondition = weatherCondition
                    });
                }
            }
            return cities;
        }

        public async Task<ForecastResponse> GetWeatherForecastAsync(string city)
        {
            string url = $"{ApiUrl}?q={city}&appid={ApiKey}&units=metric";
            var response = await _httpClient.GetFromJsonAsync<ForecastResponse>(url);
            return response;
        }

        public async Task<WeatherData> GetCurrentWeatherAsync(string city)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}&units=metric";
            var response = await _httpClient.GetFromJsonAsync<WeatherData>(url);
            return response;
        }
    }
}
