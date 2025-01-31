using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Services;

namespace WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly WeatherService _weatherService;

        public CityController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet(Name = "MostVisitedCities")]
        public async Task<IActionResult> GetMostVisitedCities()
        {
            var topCities = await _weatherService.GetMostVisitedCities();

            var response = new
            {
                message = topCities.Count > 0 ? "success" : "No data found",
                data = topCities
            };

            return Ok(response);
        }
    }
}
