using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    internal class WeatherStationFramework
    {
        private float lastSetTemperature;
        private float lastSetPressure;
        private float lastSetHumidity;
        private Dispatcher dispatcher;
        private Dispatcher Dispatcher => dispatcher;

        public WeatherStationFramework(Dispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
        }

        public void UpdateWeatherParameters(float temperature, float pressure, float humidity)
        {
            lastSetTemperature = temperature;
            lastSetPressure = pressure;
            lastSetHumidity = humidity;
            AnalyseReadingDifference(temperature, pressure, humidity);

            ContextObject contextObject = new ContextObject(temperature, pressure, humidity);
            Dispatcher.Dispatch(contextObject);
        }

        private void AnalyseReadingDifference(float temperature, float pressure, float humidity)
        {
            float tempDiff = temperature - lastSetTemperature;
            float pressDiff = pressure - lastSetPressure;
            float humidityDiff = humidity - lastSetHumidity;
            Console.WriteLine("Difference in readings: {0} {1} {2}", tempDiff, pressDiff, humidityDiff);
        }
    }
}
