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
        public string WeatherTypes;
        public double Temperature;

        public Weather()
        {
            random = new Random();
        }
        public void GetWeatherTemperature()
        {
            Temperature = random.Next(50, 90);
        }
        public void GetWeatherForecast()
        {
            List<string> TypesOfWeather = new List<string> { "Rainy", "Sunny", "Partly Cloudy" };
            WeatherTypes = TypesOfWeather[random.Next(0, 2)];
        }
        public void GetTodayForecast()
        {
            Console.WriteLine("\n Today Forecast");
            GetWeatherForecast();
            Console.WriteLine($" Weather: {WeatherTypes}");
            GetWeatherTemperature();
            Console.WriteLine($" Temperature: {Temperature}° degree");
        }




        //public void GetNextDayForecast()
        //{
        //    Console.WriteLine("\n The Next Day Forecast");
        //    GetWeatherForecast();
        //    Console.WriteLine($" Weather: {WeatherTypes}");
        //    GetWeatherTemperature();
        //    Console.WriteLine($" Temperature: {Temperature}");
        //}
    }
}
