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
        private IDispatcher dispatcher;
        private IDispatcher Dispatcher => dispatcher;

        public WeatherStationFramework(IDispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
        }

        public void UpdateWeatherFactors(float temperature, float pressure, float humidity)
        {
            AnalyseReadingDifference(temperature, pressure, humidity);
            lastSetTemperature = temperature;
            lastSetPressure = pressure;
            lastSetHumidity = humidity;

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
