using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        Random random;
        public int Temperature;
        public int TodayTemperature;
        public string WeatherTypes;
        public string WeatherTypesForecast;
        public Weather()
        {
            random = new Random();
            TodayTemperature = 0;
            WeatherTypesForecast = "";
        }
        public void GetWeatherTemperatureToday()
        {
            Temperature = random.Next(50, 90);
            TodayTemperature = Temperature;
        }
        public void GetWeatherForecastToday()
        {
            List<string> TypesOfWeather = new List<string> { "Rainy", "Sunny", "Partly Cloudy" };
            WeatherTypes = TypesOfWeather[random.Next(0, 2)];
            WeatherTypesForecast = WeatherTypes;
        }
    }
}
