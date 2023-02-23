using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern.WeatherFactorsContextObjects
{
    internal class HumidityContextObject : IContextObject
    {
        private float humidity;
        public float Pressure => humidity;
        public HumidityContextObject(float humidity)
        {
            this.humidity = humidity;
        }
    }
}
