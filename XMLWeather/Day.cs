using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    class Day
    {
        public string clouds, windDir, maxTemp, minTemp, rainPer, wind;

        public Day(string _clouds, string _maxTemp, string _minTemp, string _rainPer, string _wind,  string _windDir)
        {
            clouds = _clouds;
            windDir = _windDir;
            maxTemp = _maxTemp;
            minTemp = _minTemp;
            rainPer = _rainPer;
            wind = _wind;
        }
    }
}
