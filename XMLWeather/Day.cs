﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime,eveTemp,nightTemp, condition, conditionFore, location, tempHigh, tempLow, 
            windSpeed, windDirection, precipitation, visibility;

        /// <summary>
        /// This will create a blank day object where all values are set to "" initially
        /// </summary>
        public Day()
        {
            date = currentTemp = currentTime = eveTemp=nightTemp = condition=conditionFore = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = "";
        }
    }
}
