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
        string clouds, clouds2, maxTemp, minTemp, rainPer, wind;

        public Day(string _clouds, string _maxTemp, string _minTemp, string _rainPer, string _wind,  string _clouds2)
        {
            clouds = _clouds;
            clouds2 = _clouds2;
            maxTemp = _maxTemp;
            minTemp = _minTemp;
            rainPer = _rainPer;
            wind = _wind;
        }
    }
}
