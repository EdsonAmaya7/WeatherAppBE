
namespace WeatherAPI.Models
{
    public class City
    {
        public int id { get; set; }
        public string slug { get; set; } = string.Empty;
        public string city_slug { get; set; } = string.Empty;
        public string display { get; set; } = string.Empty;
        public string ascii_display { get; set; } = string.Empty;
        public string city_name { get; set; } = string.Empty;
        public string city_ascii_name { get; set; } = string.Empty;
        public string state { get; set; } = string.Empty;
        public string country { get; set; } = string.Empty;
        public string lat { get; set; } = string.Empty;
        public string @long { get; set; } = string.Empty;
        public string result_type { get; set; } = string.Empty;
        public string popularity { get; set; } = string.Empty;
    }

    public class TopCities
    {
        public string display { get; set; } = string.Empty;
        public string lat { get; set; } = string.Empty;
        public string @long { get; set; } = string.Empty;
    }

    public class CityResponse
    {
        public string display { get; set; } = string.Empty;
        public string lat { get; set; } = string.Empty;
        public string @long { get; set; } = string.Empty;
        public string currentTemperature { get; set; } = string.Empty;
        public string weatherCondition { get; set; } = string.Empty;
    }

}