using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    public class DataReadingContextObject
    {
        private float temperatureReading;
        private float pressureReading;
        private float humidityReading;
        public float TemperatureReading => temperatureReading;
        public float PressureReading => pressureReading;
        public float HumidityReading => humidityReading;
        public DataReadingContextObject(float temperatureReading, float pressureReading, float humidityReading)
        {
            this.temperatureReading = temperatureReading;
            this.pressureReading = pressureReading;
            this.humidityReading= humidityReading;
        }
    }
}
