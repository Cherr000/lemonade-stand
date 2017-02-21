using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string choice;

        public void WeatherRandomPick()
        {
            Random random = new Random();
            List<string> choices = new List<string> { "Rain", "Sunny", "Partly Cloudy", "Sunny With Light Rain", "Cloudy" };
            choice = choices[random.Next(0, 4)];
        }
    }
}
