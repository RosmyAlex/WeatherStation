using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    internal class WeatherStation
    {
        public static void main(String[] args)
        {
            WeatherData weatherData = new WeatherData();

            var currentDisplay = new CurrentConditionDisplayObserver(weatherData);
            var statisticsDisplay = new StatisticsDisplayObserver(weatherData);
            var forecastDisplay = new ForecastDisplayObserver(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            weatherData.RemoveObserver(forecastDisplay);
            weatherData.SetMeasurements(62, 90, 28.1f);
        }
    }
}
