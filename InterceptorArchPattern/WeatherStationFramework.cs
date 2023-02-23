using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.InterceptorArchPattern.WeatherFactorsContextObjects;
using WeatherStation.InterceptorArchPattern.WeatherUpdateDispatchers;

namespace WeatherStation.InterceptorArchPattern
{
    internal class WeatherStationFramework
    {
        private float lastSetTemperature;
        private float lastSetPressure;
        private float lastSetHumidity;

        const float MAX_STD_TEMP = 100;
        const float MAX_STD_PRESSURE = 100;
        const float MAX_STD_HUMIDITY = 100;
        private IDispatcher updateDispatcher;
        private IDispatcher UpdateDispatcher
        {
            get 
            {
                if (updateDispatcher == null)
                {
                    updateDispatcher = new UpdateDispatcher();
                }
                return updateDispatcher;
            }
        }

        public void UpdateTemperature(float temperature)
        {
            AnalyseReadingDifference(temperature, lastSetTemperature);
            lastSetTemperature = temperature;

            IContextObject contextObject = ContextObjectFactory.CreateContextObject(WeatherFactorType.Temperature, temperature);
            UpdateDispatcher?.TemperatureUpdate(contextObject);
        }
        public void UpdatePressure(float pressure)
        {
            AnalyseReadingDifference(pressure, lastSetPressure);
            lastSetPressure = pressure;

            IContextObject contextObject = ContextObjectFactory.CreateContextObject(WeatherFactorType.Pressure, pressure);
            UpdateDispatcher?.PressureUpdate(contextObject);
        }
        public void UpdateHumidity(float humidity)
        {
            AnalyseReadingDifference(humidity, lastSetHumidity);
            lastSetHumidity = humidity;

            IContextObject contextObject = ContextObjectFactory.CreateContextObject(WeatherFactorType.Humidity, humidity);
            UpdateDispatcher?.HumidityUpdate(contextObject);
        }
        public void RegisterInterceptor(IInterceptor interceptor)
        {
            UpdateDispatcher?.Register(interceptor);
        }

        //private void CheckNoiseInReading(float temperature, float pressure, float humidity)
        //{
        //    if (temperature > MAX_STD_TEMP || pressure > MAX_STD_PRESSURE || humidity > MAX_STD_HUMIDITY)
        //    {

        //    }
        //}

        private void AnalyseReadingDifference(float newReading, float lastReading)
        {
            float diffInReading = newReading - lastReading;
            Console.WriteLine("Difference in readings: {0}", diffInReading);
        }
    }
}
