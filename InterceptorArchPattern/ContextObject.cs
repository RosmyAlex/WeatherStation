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
        private float pressure;
        private float humidity;
        public float Temperature => temperature;
        public float Pressure => pressure;
        public float Humidity => humidity;
        public ContextObject(float temperature, float pressure, float humidity)
        {
            this.temperature=temperature;
            this.pressure=pressure;
            this.humidity=humidity;
        }
    }
}
