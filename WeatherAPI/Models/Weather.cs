using System.Text.Json.Serialization;

namespace WeatherAPI.Models
{
    public class WeatherData
    {
        public long Dt { get; set; } // Fecha en formato Unix
        public MainData Main { get; set; }
        public List<WeatherDescription> Weather { get; set; }
        public string Dt_txt { get; set; } // Fecha en formato YYYY-MM-DD
    }

    public class MainData
    {
        public double Temp { get; set; } // Temperatura en Centigrados
        public double Feels_like { get; set; } 
        public double Temp_min { get; set; }
        public double Temp_max { get; set; } 
        public int Pressure { get; set; } 
        public int Humidity { get; set; } 
    }

    public class WeatherDescription
    {
        public string Main { get; set; } // Condición climática 
        public string Description { get; set; } 
        public string Icon { get; set; } // Ícono del clima
    }

    public class ForecastResponse
    {
        public string Cod { get; set; } // Código de respuesta
        public int Message { get; set; } // Mensaje de respuesta
        public int Cnt { get; set; } // Número de pronosticos
        public List<WeatherData> List { get; set; } // Lista de pronosticos
        public CityData City { get; set; } // Información de la ciudad
    }

    public class CityData
    {
        public string Name { get; set; } // Nombre de la ciudad
        public CoordData Coord { get; set; } // Coordenadas de la ciudad
        public string Country { get; set; } // País
    }

    public class CoordData
    {
        public double Lat { get; set; } // Latitud
        public double Lon { get; set; } // Longitud
    }

}
