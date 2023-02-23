using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern.WeatherFactorsContextObjects
{
    internal class PressureContextObject : IContextObject
    {
        private float pressure;
        public float Pressure => pressure;
        public PressureContextObject(float temperature)
        {
            this.pressure = pressure;
        }
    }
}
