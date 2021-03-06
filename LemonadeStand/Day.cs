﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Day
    {
        public Customer customer;
        public Weather weather;
        public int days;
        public Day()
        {
            customer = new Customer();
            weather = new Weather();
            days = 0;
        }
        public void SetDayPlay()
        {
            Console.WriteLine("\n How Many Day Do You Want To Play?");
            Console.Write(" Enter Number Here: ");
            try
            {
                days = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(" Please Enter A Number");
                SetDayPlay();
            }

        }
        public void GetTodayForecast()
        {
            weather.GetWeatherTemperatureToday();
            weather.GetWeatherForecastToday();
            Console.WriteLine($"\n Today Forecast Will Be {weather.WeatherTypesForecast} And {weather.TodayTemperature}° F");
            Console.ReadLine();
        }
        public void GetGuessForecast()
        {
            weather.GetWeatherTemperatureToday();
            weather.GetWeatherForecastToday();
            Console.WriteLine($"\n Next Day Forecast Will Be {weather.WeatherTypesForecast} And {weather.TodayTemperature}° F");
            Console.WriteLine(" Keep In Mind That THe Forscast Can Change");
        }
    }
}
