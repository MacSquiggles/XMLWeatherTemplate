using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    class Day
    {
        string clouds, maxTemp, minTemp, rainPer, wind;
        int date;

        public Day(string _clouds, string _maxTemp, string _minTemp, string _rainPer, string _wind, int _date)
        {
            clouds = _clouds;
            maxTemp = _maxTemp;
            minTemp = _minTemp;
            rainPer = _rainPer;
            wind = _wind;
            date = _date;
        }
    }
}
