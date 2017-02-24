using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Weather weather;
        public Day()
        {
            weather = new Weather();
        }
        public void Day1()
        {
        }

        public void DisplayWeather()
        {
            weather.GetTodayForecast();
            Console.WriteLine(" ------------------------");
        }
    }
}