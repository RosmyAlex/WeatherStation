using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern.WeatherFactorsContextObjects
{
    internal class TemperatureContextObject : IContextObject
    {
        private float temperature;
        public float Temperature => temperature;
        public TemperatureContextObject(float temperature)
        {
            this.temperature = temperature;
        }
    }
}
