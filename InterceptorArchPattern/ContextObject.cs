using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    internal class ContextObject
    {
        private float temperature;
        private float humidity;
        private float pressure;
        public ContextObject(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        internal float Temperature { get { return temperature;} }
        internal float Humidity { get { return humidity;} }
        internal float Pressure { get { return pressure; } }
    }
}
