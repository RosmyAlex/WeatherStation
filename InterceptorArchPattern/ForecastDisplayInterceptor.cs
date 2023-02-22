using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    internal class ForecastDisplayInterceptor : IInterceptor
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private float humidity;
        private float temperature;
        public void OnWeatherParamsChanged(ContextObject contextObject)
        {
            lastPressure = currentPressure;
            currentPressure = contextObject.Pressure;
            humidity = contextObject.Humidity;
            temperature = contextObject.Temperature;
            Console.WriteLine("Forecast: ");
            DisplayHumidityForecast();
            DisplayTemperatureForecast();
            DisplayPressureForecast();
        }
        public void DisplayHumidityForecast()
        {
            if (humidity>50)
            {
                Console.WriteLine("Ideal humidity for health and comfort");
            }
            else
            {
                Console.WriteLine("Not an Ideal humidity for health and comfort");
            }
        }
        private void DisplayTemperatureForecast()
        {
            if (temperature>30)
            {
                Console.WriteLine("Weather is sunny");
            }
            else
            {
                Console.WriteLine("Weather is pleasant");
            }
        }
        private void DisplayPressureForecast()
        {
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }
}
