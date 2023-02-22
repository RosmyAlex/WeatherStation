using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    internal class StatisticsDisplayInterceptor : IInterceptor
    {
        public void OnWeatherParamsChanged(ContextObject contextObject)
        {
            float maxTemp = 0.0f;
            float minTemp = 200;
            float tempSum = 0.0f;
            int numReadings =10;
            float newTemp = contextObject.Temperature;
            tempSum += newTemp;
            numReadings++;

            if (newTemp > maxTemp)
            {
                maxTemp = newTemp;
            }

            if (newTemp < minTemp)
            {
                minTemp = newTemp;
            }

            Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
                + "/" + maxTemp + "/" + minTemp);
        }
    }
}
